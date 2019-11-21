using System;
using System.IO;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MissionPlanner.Comms
{
    public class CommsWebSocket: ICommsSerial
    {
        public ClientWebSocket client = new ClientWebSocket();
        private Thread thws;
        private bool readrun = false;

        public void Dispose()
        {
            readrun = false;
            client.Dispose();
        }

        public Stream BaseStream => Stream.Null;
        public int BaudRate { get; set; }
        public int BytesToRead { get; }
        public int BytesToWrite { get; }
        public int DataBits { get; set; }
        public bool DtrEnable { get; set; }
        public bool IsOpen
        {
            get { return client.State == WebSocketState.Open; }
        }
        public string PortName { get; set; }
        public int ReadBufferSize { get; set; }
        public int ReadTimeout { get; set; }
        public bool RtsEnable { get; set; }
        public int WriteBufferSize { get; set; }
        public int WriteTimeout { get; set; }
        public void Close()
        {
            client.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None).RunSynchronously();
        }

        public void DiscardInBuffer()
        {
            ReadExisting();
        }

        public void Open()
        {
            client.ConnectAsync(new Uri(PortName), CancellationToken.None).RunSynchronously();

            thws = new Thread(ReadSocket);
            thws.Start();
        }

        private async void ReadSocket()
        {
            readrun = true;
            var readto = new byte[4000];
            var rcvBuffer = new ArraySegment<byte>(readto, 0, readto.Length);
            while (readrun)
            {
                await client.ReceiveAsync(rcvBuffer, CancellationToken.None);


            }
        }

        public int Read(byte[] readto, int offset, int length)
        {
            VerifyConnected();
            try
            {
                if (length < 1) return 0;

                var rcvBuffer = new ArraySegment<byte>(readto, offset, length);

                return 0;
            }
            catch
            {
                throw new Exception("Socket Closed");
            }
        }

        private void VerifyConnected()
        {
            if (client.State == WebSocketState.Open)
                return;

            throw new Exception("CommsWebSocket not open");
        }

        public int ReadByte()
        {
            VerifyConnected();
            var count = 0;
            while (BytesToRead == 0)
            {
                Thread.Sleep(1);
                if (count > ReadTimeout)
                    throw new Exception("CommsWebSocket Timeout on read");
                count++;
            }

            var buffer = new byte[1];
            Read(buffer, 0, 1);
            return buffer[0];
        }

        public int ReadChar()
        {
            VerifyConnected();
            return ReadByte();
        }

        public string ReadExisting()
        {
            VerifyConnected();
            //fixme;
            var data = new byte[0];
            if (data.Length > 0)
                Read(data, 0, data.Length);

            var line = Encoding.ASCII.GetString(data, 0, data.Length);

            return line;
        }

        public void WriteLine(string line)
        {
            VerifyConnected();

            line = line + "\n";
            Write(line);
        }

        public void Write(string line)
        {
            VerifyConnected();

            var data = new ASCIIEncoding().GetBytes(line);
            Write(data, 0, data.Length);
        }

        public void Write(byte[] write, int offset, int length)
        {
            VerifyConnected();

            try
            {
                var txBuffer = new ArraySegment<byte>(write, offset, length);
                client.SendAsync(txBuffer, WebSocketMessageType.Binary, false, CancellationToken.None);
            }
            catch
            {
            } 
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

        public void toggleDTR()
        {
        
        }
    }
}
