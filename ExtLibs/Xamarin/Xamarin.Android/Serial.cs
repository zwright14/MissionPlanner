using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissionPlanner.Comms;
using System.IO;
using System.Threading;
using Android.Hardware.Usb;
using Android.Runtime;
using Hoho.Android.UsbSerial.Driver;

namespace Xamarin.Android
{
    public class Serial : CdcAcmSerialDriver.CdcAcmSerialPort, ICommsSerial, IUsbSerialPort
    {
        protected Serial(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public Serial(CdcAcmSerialDriver usbManager, UsbDevice usbDevice, int portNumber) : base(usbManager, usbDevice, portNumber)
        {
        }

        class instream: Stream
        {
            private readonly Serial _serial;

            internal instream(Serial serial)
            {
                _serial = serial;
            }

            public override void Flush()
            {
                
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotImplementedException();
            }

            public override void SetLength(long value)
            {
                throw new NotImplementedException();
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                return _serial.Read(buffer, offset, count);
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                _serial.Write(buffer, offset, count);
            }

            public override bool CanRead { get; } = true;
            public override bool CanSeek { get; } = false;
            public override bool CanWrite { get; } = true;
            public override long Length { get; }
            public override long Position { get; set; }
        }

        public Stream BaseStream { get; internal set; }
        public int BaudRate { get; set; }
        public int BytesToRead
        {
            get { return MReadBuffer.Count; }
        }
        public int BytesToWrite
        {
            get { return MWriteBuffer.Count; }
        }
        public int DataBits { get; set; }
        public bool DtrEnable
        {
            get { return DTR;}
            set { DTR = value; }
        }
        public bool IsOpen { get; internal set; }
        public string PortName { get; set; }
        public int ReadBufferSize { get; set; }
        public int ReadTimeout { get; set; }
        public bool RtsEnable
        {
            get { return RTS;}
            set { RTS = value; }
        }
        public int WriteBufferSize { get; set; }
        public int WriteTimeout { get; set; }

        public void DiscardInBuffer()
        {
            MReadBuffer.Clear();
        }

        public void Open()
        {
            SetParameters(BaudRate, DataBits, StopBits.One, Parity.None);
            base.Open(MConnection);
            IsOpen = true;
            BaseStream = new instream(this);
        }

        public new void Close()
        {
            IsOpen = false;
            base.Close();
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            return base.Read(buffer, count);
        }

        public int ReadByte()
        {
            var buffer = new byte[1];
            Read(buffer, 0, 1);
            return buffer[0];
        }

        public int ReadChar()
        {
            return ReadByte();
        }

        public string ReadExisting()
        {
            var data = new byte[0];
            if (data.Length > 0)
                Read(data, 0, data.Length);

            var line = Encoding.ASCII.GetString(data, 0, data.Length);

            return line;
        }

        public string ReadLine()
        {
            var temp = new byte[4000];
            var count = 0;
            var timeout = 0;

            while (timeout <= 100)
            {
                if (!IsOpen) break;
                if (BytesToRead > 0)
                {
                    var letter = (byte)ReadByte();

                    temp[count] = letter;

                    if (letter == '\n') // normal line
                        break;

                    count++;
                    if (count == temp.Length)
                        break;
                    timeout = 0;
                }
                else
                {
                    timeout++;
                    Thread.Sleep(5);
                }
            }

            Array.Resize(ref temp, count + 1);

            return Encoding.ASCII.GetString(temp, 0, temp.Length);
        }

        public void Write(string text)
        {
            base.Write(ASCIIEncoding.ASCII.GetBytes(text), text.Length);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            base.Write(buffer.Skip(offset).ToArray(), count - offset);
        }

        public void WriteLine(string text)
        {
            Write(text + "\r\n");
        }

        public void toggleDTR()
        {
            
        }
    }
}
