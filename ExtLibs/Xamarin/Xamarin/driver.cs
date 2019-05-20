using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Utilities;
using MissionPlanner.Utilities.Drawing;
using Timer = System.Windows.Forms.Timer;

namespace Xamarin
{
    public class driver : XplatUIDriver
    {
        // Focus tracking
        static IntPtr ActiveWindow;     // Handle of the active window
        static IntPtr FocusWindow;      // Handle of the window with keyboard focus (if any)

        // Modality support
        static Stack ModalWindows;		// Stack of our modal windows

        static ArrayList unattached_timer_list; // holds timers that are enabled but not attached to a window.
        internal static bool in_doevents = false;
        static Hashtable MessageQueues;
        public driver()
        {
            ActiveWindow = IntPtr.Zero;
            FocusWindow = IntPtr.Zero;
            ModalWindows = new Stack(3);

            MessageQueues = Hashtable.Synchronized(new Hashtable(7));
            unattached_timer_list = ArrayList.Synchronized(new ArrayList(3));
        }

        public override event EventHandler Idle;

        public override Screen[] AllScreens => new Screen[] { };
        public override int CaptionHeight => 0;

        public override System.Drawing.Size CursorSize => new Size(10,10);

        public override bool DragFullWindows => true;

        public override System.Drawing.Size DragSize => new Size(10, 10);

        public override System.Drawing.Size FrameBorderSize => new Size(10, 10);

        public override System.Drawing.Size IconSize => new Size(10, 10);

        public override int KeyboardDelay => 1;
        public override int KeyboardSpeed => 1;
        public override System.Drawing.Size MaxWindowTrackSize => new Size(10, 10);

        public override bool MenuAccessKeysUnderlined => true;

        public override System.Drawing.Size MinimizedWindowSpacingSize => new Size(10, 10);

        public override System.Drawing.Size MinimumWindowSize => new Size(10, 10);

        public override int MouseButtonCount => 3;
        public override bool MouseButtonsSwapped => false;
        public override bool MouseWheelPresent => true;
        public override System.Drawing.Size SmallIconSize => new Size(10, 10);
        public override bool ThemesEnabled => true;
        public override Rectangle VirtualScreen => new Rectangle(0, 0, 1024, 768);

        public override Rectangle WorkingArea => new Rectangle(0,0,1024,768);
        public override void Activate(IntPtr handle)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);

            if (hwnd != null)
            {
                //lock (XlibLock)
                {
                    if (true /* the window manager supports NET_ACTIVE_WINDOW */)
                    {
                        //SendNetWMMessage(hwnd.whole_window, _NET_ACTIVE_WINDOW, (IntPtr)1, IntPtr.Zero, IntPtr.Zero);
                        XEventQueue q = null;
                        lock (unattached_timer_list)
                        {
                            foreach (Timer t in unattached_timer_list)
                            {
                                if (q == null)
                                    q = (XEventQueue)MessageQueues[Thread.CurrentThread];
                                t.thread = q.Thread;
                                q.timer_list.Add(t);
                            }
                            unattached_timer_list.Clear();
                        }
                    }
                    // 					else {
                    // 						XRaiseWindow(DisplayHandle, handle);
                    // 					}
                }
            }
        }
        
        public override void AudibleAlert(AlertType alert)
        {
            
        }

        public override void BeginMoveResize(IntPtr handle)
        {
            
        }

        public override bool CalculateWindowRect(ref System.Drawing.Rectangle ClientRect, CreateParams cp, System.Windows.Forms.Menu menu, out System.Drawing.Rectangle WindowRect)
        {
            WindowRect = Hwnd.GetWindowRectangle(cp, menu, ClientRect);
            return true;
        }

        public override void CaretVisible(IntPtr hwnd, bool visible)
        {
            
        }

        public override void ClientToScreen(IntPtr hwnd, ref int x, ref int y)
        {
            
        }

        public override int[] ClipboardAvailableFormats(IntPtr handle)
        {
            return new int[] { };
        }

        public override void ClipboardClose(IntPtr handle)
        {
            
        }

        public override int ClipboardGetID(IntPtr handle, string format)
        {
            return 0;
        }

        public override IntPtr ClipboardOpen(bool primary_selection)
        {
            return IntPtr.Zero;
            
        }

        public override object ClipboardRetrieve(IntPtr handle, int id, XplatUI.ClipboardToObject converter)
        {
            return null;
        }

        public override void ClipboardStore(IntPtr handle, object obj, int id, XplatUI.ObjectToClipboard converter, bool copy)
        {
            
        }

        public override void CreateCaret(IntPtr hwnd, int width, int height)
        {
            
        }
        public override IntPtr CreateWindow(CreateParams cp)
        {

            Hwnd hwnd;
            Hwnd parent_hwnd = null;
            int X;
            int Y;
            int Width;
            int Height;
            IntPtr ParentHandle;
            IntPtr WholeWindow = IntPtr.Zero;
            IntPtr ClientWindow;

            int[] atoms;

            hwnd = new Hwnd();



            X = cp.X;
            Y = cp.Y;
            Width = cp.Width;
            Height = cp.Height;

            if (Width < 1) Width = 1;
            if (Height < 1) Height = 1;

            if (cp.Parent != IntPtr.Zero)
            {
                parent_hwnd = Hwnd.ObjectFromHandle(cp.Parent);
                ParentHandle = parent_hwnd.client_window;
            }
            else
            {
                if (StyleSet(cp.Style, WindowStyles.WS_CHILD))
                {
                    // We need to use our foster parent window until this poor child gets it's parent assigned
                    // ParentHandle = FosterParent;
                }
                else
                {
                    // ParentHandle = RootWindow;
                }
            }

            // Set the default location location for forms.
            Point next;
            if (cp.control is Form)
            {
                next = Hwnd.GetNextStackedFormLocation(cp);
                X = next.X;
                Y = next.Y;
            }

            // Save what's under the toolwindow
            if (ExStyleSet(cp.ExStyle, WindowExStyles.WS_EX_TOOLWINDOW))
            {

            }


            // If we're a popup without caption we override the WM
            if (StyleSet(cp.Style, WindowStyles.WS_POPUP) && !StyleSet(cp.Style, WindowStyles.WS_CAPTION))
            {

            }

            hwnd.x = X;
            hwnd.y = Y;
            hwnd.width = Width;
            hwnd.height = Height;
            hwnd.parent = Hwnd.ObjectFromHandle(cp.Parent);
            hwnd.initial_style = cp.WindowStyle;
            hwnd.initial_ex_style = cp.WindowExStyle;

            if (StyleSet(cp.Style, WindowStyles.WS_DISABLED))
            {
                hwnd.enabled = false;
            }

            ClientWindow = IntPtr.Zero;

            ClientWindow = new IntPtr(new Random().Next());

            if (cp.control is Form)
            {
                WholeWindow = ClientWindow;
            }
            // WholeWindow = new IntPtr(new Random().Next());

            //   if ((WholeWindow == IntPtr.Zero) || (ClientWindow == IntPtr.Zero))
            {
                //      throw new Exception("Could not create X11 windows");
            }

            hwnd.Queue = ThreadQueue(Thread.CurrentThread);
            hwnd.WholeWindow = WholeWindow;
            hwnd.ClientWindow = ClientWindow;

            //   DriverDebug("Created window {0:X} / {1:X} parent {2:X}, Style {3}, ExStyle {4}", ClientWindow.ToInt32(), WholeWindow.ToInt32(), hwnd.parent != null ? hwnd.parent.Handle.ToInt32() : 0, (WindowStyles)cp.Style, (WindowExStyles)cp.ExStyle);

            if (!StyleSet(cp.Style, WindowStyles.WS_CHILD))
            {
                if ((X != unchecked((int)0x80000000)) && (Y != unchecked((int)0x80000000)))
                {

                }
            }



            if (ExStyleSet(cp.ExStyle, WindowExStyles.WS_EX_TOPMOST))
                SetTopmost(hwnd.whole_window, true);





            if (StyleSet(cp.Style, WindowStyles.WS_MINIMIZE))
            {
                SetWindowState(hwnd.Handle, FormWindowState.Minimized);
            }
            else if (StyleSet(cp.Style, WindowStyles.WS_MAXIMIZE))
            {
                SetWindowState(hwnd.Handle, FormWindowState.Maximized);
            }


            // Set caption/window title
            Text(hwnd.Handle, cp.Caption);

            SendMessage(hwnd.Handle, Msg.WM_CREATE, (IntPtr)1, IntPtr.Zero /* XXX unused */);

            if (StyleSet(cp.Style, WindowStyles.WS_VISIBLE))
            {
                hwnd.visible = true;
                //
                hwnd.mapped = true;
                //  MapWindow(hwnd, WindowType.Both);
                //   if (!(Control.FromHandle(hwnd.Handle) is Form))
                SendMessage(hwnd.Handle, Msg.WM_SHOWWINDOW, (IntPtr)1, IntPtr.Zero);
            }

            return hwnd.Handle;
        }

        public override IntPtr CreateWindow(IntPtr Parent, int X, int Y, int Width, int Height)
        {
            CreateParams create_params = new CreateParams();

            create_params.Caption = "";
            create_params.X = X;
            create_params.Y = Y;
            create_params.Width = Width;
            create_params.Height = Height;

            create_params.ClassName = XplatUI.GetDefaultClassName(GetType());
            create_params.ClassStyle = 0;
            create_params.ExStyle = 0;
            create_params.Parent = IntPtr.Zero;
            create_params.Param = 0;

            return CreateWindow(create_params);
        }

        public override IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, System.Drawing.Color cursor_pixel, System.Drawing.Color mask_pixel, int xHotSpot, int yHotSpot)
        {
            return IntPtr.Zero;

        }

        public override IntPtr DefineStdCursor(StdCursor id)
        {
            return IntPtr.Zero;
        }

        public override Bitmap DefineStdCursorBitmap(StdCursor id)
        {
            return null;
        }

        public override IntPtr DefWndProc(ref Message msg)
        {
            switch ((Msg)msg.Msg)
            {

                case Msg.WM_PAINT:
                    {
                        Hwnd hwnd;

                        hwnd = Hwnd.GetObjectFromWindow(msg.HWnd);
                        if (hwnd != null)
                        {
                            hwnd.expose_pending = false;
                        }

                        return IntPtr.Zero;
                    }

                case Msg.WM_NCPAINT:
                    {
                        Hwnd hwnd;

                        hwnd = Hwnd.GetObjectFromWindow(msg.HWnd);
                        if (hwnd != null)
                        {
                            hwnd.nc_expose_pending = false;
                        }

                        return IntPtr.Zero;
                    }
                case Msg.WM_NCCALCSIZE:
                    {
                        Hwnd hwnd;

                        if (msg.WParam == (IntPtr)1)
                        {
                            hwnd = Hwnd.GetObjectFromWindow(msg.HWnd);

                            NCCALCSIZE_PARAMS ncp;
                            ncp = (NCCALCSIZE_PARAMS)Marshal.PtrToStructure(msg.LParam, typeof(NCCALCSIZE_PARAMS));

                            // Add all the stuff X is supposed to draw.
                            Control ctrl = Control.FromHandle(hwnd.Handle);

                            if (ctrl != null)
                            {
                                Hwnd.Borders rect = Hwnd.GetBorders(ctrl.GetCreateParams(), null);

                                ncp.rgrc1.top += rect.top;
                                ncp.rgrc1.bottom -= rect.bottom;
                                ncp.rgrc1.left += rect.left;
                                ncp.rgrc1.right -= rect.right;

                                Marshal.StructureToPtr(ncp, msg.LParam, true);
                            }
                        }

                        return IntPtr.Zero;
                    }
                case Msg.WM_MOUSEWHEEL:
                    {
                        Hwnd hwnd;

                        hwnd = Hwnd.GetObjectFromWindow(msg.HWnd);

                        if ((hwnd != null) && (hwnd.parent != null))
                        {
                            SendMessage(hwnd.parent.client_window, Msg.WM_MOUSEWHEEL, msg.WParam, msg.LParam);
                            if (msg.Result == IntPtr.Zero)
                            {
                                return IntPtr.Zero;
                            }
                        }
                        return IntPtr.Zero;
                    }
            }
            return IntPtr.Zero;
        }

        public override void DestroyCaret(IntPtr hwnd)
        {

        }

        public override void DestroyCursor(IntPtr cursor)
        {

        }

        public override void DestroyWindow(IntPtr handle)
        {
            Hwnd hwnd;
            hwnd = Hwnd.ObjectFromHandle(handle);

            // The window should never ever be a zombie here, since we should
            // wait until it's completely dead before returning from 
            // "destroying" calls, but just in case....
            if (hwnd == null || hwnd.zombie)
            {

                return;
            }

            //SendParentNotify(hwnd.Handle, Msg.WM_DESTROY, int.MaxValue, int.MaxValue);

            //CleanupCachedWindows(hwnd);

            ArrayList windows = new ArrayList();

            // AccumulateDestroyedHandles(Control.ControlNativeWindow.ControlFromHandle(hwnd.Handle), windows);


            foreach (Hwnd h in windows)
            {
                SendMessage(h.Handle, Msg.WM_DESTROY, IntPtr.Zero, IntPtr.Zero);
                h.zombie = true;
            }
        }

        public override IntPtr DispatchMessage(ref MSG msg)
        {
            return NativeWindow.WndProc(msg.hwnd, msg.message, msg.wParam, msg.lParam);
        }

        public override void DoEvents()
        {


            MSG msg = new MSG();
            XEventQueue queue;



            queue = ThreadQueue(Thread.CurrentThread);

            queue.DispatchIdle = false;
             in_doevents = true;

            while (PeekMessage(queue, ref msg, IntPtr.Zero, 0, 0, (uint)PeekMessageFlags.PM_REMOVE))
            {
                Message m = Message.Create(msg.hwnd, (int)msg.message, msg.wParam, msg.lParam);

                if (System.Windows.Forms.Application.FilterMessage(ref m))
                    continue;

                TranslateMessage(ref msg);
                DispatchMessage(ref msg);

                string key = msg.hwnd + ":" + msg.message;

            }

            in_doevents = false;
            queue.DispatchIdle = true;

        }

        public override void DrawReversibleFrame(System.Drawing.Rectangle rectangle, System.Drawing.Color backColor, FrameStyle style)
        {

        }

        public override void DrawReversibleLine(System.Drawing.Point start, System.Drawing.Point end, System.Drawing.Color backColor)
        {

        }

        public override void DrawReversibleRectangle(IntPtr handle, System.Drawing.Rectangle rect, int line_width)
        {

        }

        public override void EnableThemes()
        {

        }

        public override void EnableWindow(IntPtr handle, bool Enable)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);
            if (hwnd != null)
            {
                hwnd.Enabled = Enable;
            }
        }

        public override void EndLoop(Thread thread)
        {

        }

        public override void FillReversibleRectangle(System.Drawing.Rectangle rectangle, System.Drawing.Color backColor)
        {

        }

        public override IntPtr GetActive()
        {
            return IntPtr.Zero;
        }

        public override SizeF GetAutoScaleSize(MissionPlanner.Utilities.Drawing.Font font)
        {
            Graphics g;
            float width;
            string magic_string = "The quick brown fox jumped over the lazy dog.";
            double magic_number = 44.549996948242189;

            g = new Graphics();

            width = (float)(g.MeasureString(magic_string, font).Width / magic_number);
            return new SizeF(width, font.Height);
        }

        public override MissionPlanner.Utilities.Drawing.Region GetClipRegion(IntPtr handle)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);
            if (hwnd != null)
            {
                return hwnd.UserClip;
            }

            return null;
        }

        public override void GetCursorInfo(IntPtr cursor, out int width, out int height, out int hotspot_x, out int hotspot_y)
        {
            width = height = hotspot_x = hotspot_y = 0;
        }

        public override void GetCursorPos(IntPtr hwnd, out int x, out int y)
        {
            x = Controls.Form.MousePosition.X;
            y = Controls.Form.MousePosition.Y;
        }

        public override void GetDisplaySize(out System.Drawing.Size size)
        {

        }

        public override IntPtr GetFocus()
        {
            return FocusWindow;
        }

        public override bool GetFontMetrics(Graphics g, MissionPlanner.Utilities.Drawing.Font font, out int ascent, out int descent)
        {
            ascent = descent = 0;
            return false;
        }

        public override System.Drawing.Point GetMenuOrigin(IntPtr hwnd)
        {
            return new System.Drawing.Point();
        }

        public override bool GetMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax)
        {
            XEvent xevent;
            bool client;
            Hwnd hwnd;

        ProcessNextMessage:

            if (((XEventQueue)queue_id).Count > 0)
            {
                xevent = (XEvent)((XEventQueue)queue_id).Dequeue();
            }
            else
            {
                var now = DateTime.UtcNow;
                //UpdateMessageQueue((XEventQueue)queue_id);
                if ((XEventQueue)queue_id != null)
                    CheckTimers(((XEventQueue)queue_id).timer_list, now);

                if (((XEventQueue)queue_id).Count > 0)
                {
                    xevent = (XEvent)((XEventQueue)queue_id).Dequeue();
                }
                else if (((XEventQueue)queue_id).Paint.Count > 0)
                {
                    xevent = ((XEventQueue)queue_id).Paint.Dequeue();
                }
                else
                {
                    Idle(this, EventArgs.Empty);

                    int fixme;

                    ModalWindows.ForEach(a =>
                    {
                        Hwnd hwnd2 = Hwnd.ObjectFromHandle((IntPtr)a);

                        hwnd2.Mapped = true;
                        Control ctrl = Control.FromHandle((IntPtr)a);
                        ctrl.Refresh();
                    });

                    msg.hwnd = IntPtr.Zero;
                    msg.message = Msg.WM_ENTERIDLE;
                    return true;
                }
            }

            hwnd = Hwnd.GetObjectFromWindow(xevent.AnyEvent.window);

#if DriverDebugDestroy
			if (hwnd != null)
				if (hwnd.zombie)
					Console.WriteLine ( "GetMessage zombie, got Event: " + xevent.ToString () + " for 0x{0:x}", hwnd.Handle.ToInt32());
				else	
					Console.WriteLine ( "GetMessage, got Event: " + xevent.ToString () + " for 0x{0:x}", hwnd.Handle.ToInt32());
#endif
            // Handle messages for windows that are already or are about to be destroyed.

            // we need a special block for this because unless we remove the hwnd from the paint
            // queue it will always stay there (since we don't handle the expose), and we'll
            // effectively loop infinitely trying to repaint a non-existant window.
            if (hwnd != null && hwnd.zombie && xevent.type == XEventName.Expose)
            {
                hwnd.expose_pending = hwnd.nc_expose_pending = false;
                hwnd.Queue.Paint.Remove(hwnd);
                goto ProcessNextMessage;
            }

            // We need to make sure we only allow DestroyNotify events through for zombie
            // hwnds, since much of the event handling code makes requests using the hwnd's
            // client_window, and that'll result in BadWindow errors if there's some lag
            // between the XDestroyWindow call and the DestroyNotify event.
            if (hwnd == null || hwnd.zombie && xevent.AnyEvent.type != XEventName.ClientMessage)
            {
                // DriverDebug("GetMessage(): Got message {0} for non-existent or already destroyed window {1:X}", xevent.type, xevent.AnyEvent.window.ToInt32());
                goto ProcessNextMessage;
            }


            // If we get here, that means the window is no more but there are Client Messages
            // to be processed, probably a Posted message (for instance, an WM_ACTIVATE message) 
            // We don't want anything else to run but the ClientMessage block, so reset all hwnd
            // properties that might cause other processing to occur.
            if (hwnd.zombie)
            {
                hwnd.resizing_or_moving = false;
            }

            if (hwnd.client_window == xevent.AnyEvent.window)
            {
                client = true;
                //Console.WriteLine("Client message {1}, sending to window {0:X}", msg.hwnd.ToInt32(), xevent.type);
            }
            else
            {
                client = false;
                //Console.WriteLine("Non-Client message, sending to window {0:X}", msg.hwnd.ToInt32());
            }

            msg.hwnd = hwnd.Handle;
            //
            // If you add a new event to this switch make sure to add it in
            // UpdateMessage also unless it is not coming through the X event system.
            //
            switch (xevent.type)
            {
                case XEventName.Expose:
                    {
                        if (!hwnd.Mapped)
                        {
                            if (client)
                            {
                                hwnd.expose_pending = false;
                            }
                            else
                            {
                                hwnd.nc_expose_pending = false;
                            }

                            goto ProcessNextMessage;
                        }

                        if (client)
                        {
                            if (!hwnd.expose_pending)
                            {
                                goto ProcessNextMessage;
                            }
                        }
                        else
                        {
                            if (!hwnd.nc_expose_pending)
                            {
                                goto ProcessNextMessage;
                            }
                            /*
                            switch (hwnd.border_style)
                            {
                                case FormBorderStyle.Fixed3D:
                                {
                                    Graphics g;

                                    g = Graphics.FromHwnd(hwnd.whole_window);
                                    if (hwnd.border_static)
                                        ControlPaint.DrawBorder3D(g, new Rectangle(0, 0, hwnd.Width, hwnd.Height),
                                            Border3DStyle.SunkenOuter);
                                    else
                                        ControlPaint.DrawBorder3D(g, new Rectangle(0, 0, hwnd.Width, hwnd.Height),
                                            Border3DStyle.Sunken);
                                    g.Dispose();
                                    break;
                                }

                                case FormBorderStyle.FixedSingle:
                                {
                                    Graphics g;

                                    g = Graphics.FromHwnd(hwnd.whole_window);
                                    ControlPaint.DrawBorder(g, new Rectangle(0, 0, hwnd.Width, hwnd.Height), Color.Black,
                                        ButtonBorderStyle.Solid);
                                    g.Dispose();
                                    break;
                                }
                            }*/

                            /*      DriverDebug("GetMessage(): Window {0:X} Exposed non-client area {1},{2} {3}x{4}",
                                hwnd.client_window.ToInt32(), xevent.ExposeEvent.x, xevent.ExposeEvent.y,
                                xevent.ExposeEvent.width, xevent.ExposeEvent.height);
                                */
                            Rectangle rect = new Rectangle(xevent.ExposeEvent.x, xevent.ExposeEvent.y,
                                xevent.ExposeEvent.width, xevent.ExposeEvent.height);
                            Region region = new Region(rect);
                            IntPtr hrgn = region.GetHrgn(null); // Graphics object isn't needed
                            msg.message = Msg.WM_NCPAINT;
                            msg.wParam = hrgn == IntPtr.Zero ? (IntPtr)1 : hrgn;
                            msg.refobject = region;
                            break;
                        }
                        /*
                        DriverDebug("GetMessage(): Window {0:X} Exposed area {1},{2} {3}x{4}",
                            hwnd.client_window.ToInt32(), xevent.ExposeEvent.x, xevent.ExposeEvent.y,
                            xevent.ExposeEvent.width, xevent.ExposeEvent.height);
                        if (Caret.Visible == true)
                        {
                            Caret.Paused = true;
                            HideCaret();
                        }

                        if (Caret.Visible == true)
                        {
                            ShowCaret();
                            Caret.Paused = false;
                        }
                        */
                        msg.message = Msg.WM_PAINT;
                        break;
                    }
            }

            return true;
        }

        public override IntPtr GetParent(IntPtr handle, bool with_owner)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);
            if (hwnd != null && hwnd.parent != null)
            {
                return hwnd.parent.Handle;
            }
            return IntPtr.Zero;
        }

        public override IntPtr GetPreviousWindow(IntPtr hwnd)
        {
            return IntPtr.Zero;
        }

        public override bool GetText(IntPtr handle, out string text)
        {
            text = "";
            return true;
        }

        public override void GetWindowPos(IntPtr handle, bool is_toplevel, out int x, out int y, out int width, out int height, out int client_width, out int client_height)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);

            if (hwnd != null)
            {
                x = hwnd.x;
                y = hwnd.y;
                width = hwnd.width;
                height = hwnd.height;

                PerformNCCalc(hwnd);

                client_width = hwnd.ClientRect.Width;
                client_height = hwnd.ClientRect.Height;

                return;
            }

            // Should we throw an exception or fail silently?
            // throw new ArgumentException("Called with an invalid window handle", "handle");

            x = 0;
            y = 0;
            width = 0;
            height = 0;
            client_width = 0;
            client_height = 0;
        }

        public override FormWindowState GetWindowState(IntPtr handle)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);

            //   if (hwnd.cached_window_state == (FormWindowState)(-1))
            //     hwnd.cached_window_state = UpdateWindowState(handle);

            return hwnd.cached_window_state;
        }

        public override double GetWindowTransparency(IntPtr handle)
        {
            return 0;
        }

        public override void GrabInfo(out IntPtr hwnd, out bool GrabConfined, out System.Drawing.Rectangle GrabArea)
        {
            GrabConfined = false;
            GrabArea = new Rectangle();
            hwnd = IntPtr.Zero;
        }

        public override void GrabWindow(IntPtr hwnd, IntPtr ConfineToHwnd)
        {

        }

        public override void HandleException(Exception e)
        {

        }

        public override IntPtr InitializeDriver()
        {
            return IntPtr.Zero;
        }

        public override void Invalidate(IntPtr handle, System.Drawing.Rectangle rc, bool clear)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);

            if (clear)
            {
                AddExpose(hwnd, true, hwnd.X, hwnd.Y, hwnd.Width, hwnd.Height);
            }
            else
            {
                AddExpose(hwnd, true, rc.X, rc.Y, rc.Width, rc.Height);
            }
        }

        public override void InvalidateNC(IntPtr handle)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);

            AddExpose(hwnd, hwnd.WholeWindow == hwnd.ClientWindow, 0, 0, hwnd.Width, hwnd.Height);
        }

        public override bool IsEnabled(IntPtr handle)
        {
            Hwnd hwnd = Hwnd.ObjectFromHandle(handle);
            return (hwnd != null && hwnd.Enabled);
        }

        public override bool IsVisible(IntPtr handle)
        {
            Hwnd hwnd = Hwnd.ObjectFromHandle(handle);
            return (hwnd != null && hwnd.visible);
        }

        public override void KillTimer(System.Windows.Forms.Timer timer)
        {
            XEventQueue queue = (XEventQueue)MessageQueues[timer.thread];

            if (queue == null)
            {
                // This isn't really an error, MS doesn't start the timer if
                // it has no assosciated queue. In this case, remove the timer
                // from the list of unattached timers (if it was enabled).
                lock (unattached_timer_list)
                {
                    if (unattached_timer_list.Contains(timer))
                        unattached_timer_list.Remove(timer);
                }
                return;
            }
            queue.timer_list.Remove(timer);
        }

        public override void MenuToScreen(IntPtr hwnd, ref int x, ref int y)
        {

        }

        public override void OverrideCursor(IntPtr cursor)
        {

        }

        public override void PaintEventEnd(ref Message msg, IntPtr handle, bool client, PaintEventArgs pevent)
        {
            if (pevent.Graphics != null)
                pevent.Graphics.Dispose();
            pevent.SetGraphics(null);
            pevent.Dispose();
        }

        public override PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client)
        {
            PaintEventArgs paint_event;
            Hwnd hwnd;
            Hwnd paint_hwnd;

            // 
            // handle  (and paint_hwnd) refers to the window that is should be painted.
            // msg.HWnd (and hwnd) refers to the window that got the paint message.
            // 

            hwnd = Hwnd.ObjectFromHandle(msg.HWnd);
            if (msg.HWnd == handle)
            {
                paint_hwnd = hwnd;
            }
            else
            {
                paint_hwnd = Hwnd.ObjectFromHandle(handle);
            }


            Graphics dc;

            if (client)
            {
                //Graphics.FromImage(new Bitmap(hwnd.width, hwnd.height));//
                dc = Graphics.FromImage(new Bitmap(paint_hwnd.width, paint_hwnd.height));// Graphics.FromHwnd(paint_hwnd.client_window);

                Region clip_region = new Region();
                clip_region.MakeEmpty();

                foreach (Rectangle r in hwnd.ClipRectangles)
                {
                    /* Expand the region slightly.
					 * See bug 464464.
					 */
                    Rectangle r2 = Rectangle.FromLTRB(r.Left, r.Top, r.Right, r.Bottom + 1);
                    clip_region.Union(r2);
                }

                if (hwnd.UserClip != null)
                {
                    clip_region.Intersect(hwnd.UserClip);
                }

                dc.Clip = clip_region;
                paint_event = new PaintEventArgs(dc, hwnd.Invalid);
                hwnd.expose_pending = false;

                hwnd.ClearInvalidArea();

                return paint_event;
            }
            else
            {
                dc = Graphics.FromImage(new Bitmap(paint_hwnd.width, paint_hwnd.height));//Graphics.FromHwnd(paint_hwnd.whole_window);

                if (!hwnd.nc_invalid.IsEmpty)
                {
                    dc.SetClip(hwnd.nc_invalid);
                    paint_event = new PaintEventArgs(dc, hwnd.nc_invalid);
                }
                else
                {
                    paint_event = new PaintEventArgs(dc, new Rectangle(0, 0, hwnd.width, hwnd.height));
                }
                hwnd.nc_expose_pending = false;

                hwnd.ClearNcInvalidArea();

                return paint_event;
            }
        }

        public override bool PeekMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags)
        {

            XEventQueue queue = (XEventQueue)queue_id;
            bool pending;

            if ((flags & (uint)PeekMessageFlags.PM_REMOVE) == 0)
            {
                throw new NotImplementedException("PeekMessage PM_NOREMOVE is not implemented yet");    // FIXME - Implement PM_NOREMOVE flag
            }

            pending = false;
            if (queue.Count > 0)
            {
                pending = true;
            }
            else
            {
                // Only call UpdateMessageQueue if real events are pending 
                // otherwise we go to sleep on the socket
                if (((XEventQueue)queue_id).Paint.Count > 0)
                {
                    pending = true;
                }
            }

            CheckTimers(queue.timer_list, DateTime.UtcNow);

            if (!pending)
            {
                return false;
            }
            return GetMessage(queue_id, ref msg, hWnd, wFilterMin, wFilterMax);
        }

        public override bool PostMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam)
        {
            return true;
        }

        public override void PostQuitMessage(int exitCode)
        {

        }

        public override void RaiseIdle(EventArgs e)
        {

        }

        public override void RequestAdditionalWM_NCMessages(IntPtr hwnd, bool hover, bool leave)
        {

        }

        public override void RequestNCRecalc(IntPtr handle)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);

            if (hwnd == null)
            {
                return;
            }

            PerformNCCalc(hwnd);
            SendMessage(handle, Msg.WM_WINDOWPOSCHANGED, IntPtr.Zero, IntPtr.Zero);
            InvalidateNC(handle);
        }

        public override void ResetMouseHover(IntPtr hwnd)
        {

        }

        public override void ScreenToClient(IntPtr handle, ref int x, ref int y)
        {
            int dest_x_return;
            int dest_y_return;
            IntPtr child;
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);

           // lock (XlibLock)
            {
              //  XTranslateCoordinates(DisplayHandle, RootWindow, hwnd.client_window, x, y, out dest_x_return, out dest_y_return, out child);
            }

            //x = dest_x_return;
            //y = dest_y_return;
        }

        public override void ScreenToMenu(IntPtr handle, ref int x, ref int y)
        {
            int dest_x_return = x;
            int dest_y_return = y;
            IntPtr child;
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);

            //lock (XlibLock)
            {
               // XTranslateCoordinates(DisplayHandle, RootWindow, hwnd.whole_window, x, y, out dest_x_return, out dest_y_return, out child);
            }

            Form form = Control.FromHandle(handle) as Form;
            if (form != null && form.window_manager != null)
            {
                dest_y_return -= form.window_manager.TitleBarHeight;
            }

            x = dest_x_return;
            y = dest_y_return;
        }

        public override void ScrollWindow(IntPtr handle, System.Drawing.Rectangle area, int XAmount, int YAmount, bool with_children)
        {
            Hwnd hwnd;
            IntPtr gc;


            hwnd = Hwnd.ObjectFromHandle(handle);

            Rectangle r = Rectangle.Intersect(hwnd.Invalid, area);
            if (!r.IsEmpty)
            {
                /* We have an invalid area in the window we're scrolling. 
				   Adjust our stored invalid rectangle to to match the scrolled amount */

                r.X += XAmount;
                r.Y += YAmount;

                if (r.X < 0)
                {
                    r.Width += r.X;
                    r.X = 0;
                }

                if (r.Y < 0)
                {
                    r.Height += r.Y;
                    r.Y = 0;
                }

                if (area.Contains(hwnd.Invalid))
                    hwnd.ClearInvalidArea();
                hwnd.AddInvalidArea(r);
            }

           // gc_values = new XGCValues();

            if (with_children)
            {
                //gc_values.subwindow_mode = GCSubwindowMode.IncludeInferiors;
            }

           // gc = XCreateGC(DisplayHandle, hwnd.client_window, IntPtr.Zero, ref gc_values);

            Rectangle visible_rect = GetTotalVisibleArea(hwnd.client_window);
            visible_rect.Intersect(area);

            Rectangle dest_rect = visible_rect;
            dest_rect.Y += YAmount;
            dest_rect.X += XAmount;
            dest_rect.Intersect(area);

            Point src = new Point(dest_rect.X - XAmount, dest_rect.Y - YAmount);
            //XCopyArea(DisplayHandle, hwnd.client_window, hwnd.client_window, gc, src.X, src.Y,dest_rect.Width, dest_rect.Height, dest_rect.X, dest_rect.Y);

            Rectangle dirty_area = GetDirtyArea(area, dest_rect, XAmount, YAmount);
            AddExpose(hwnd, true, dirty_area.X, dirty_area.Y, dirty_area.Width, dirty_area.Height);

           
        }
        Rectangle GetDirtyArea(Rectangle total_area, Rectangle valid_area, int XAmount, int YAmount)
        {
            Rectangle dirty_area = total_area;

            if (YAmount > 0)
                dirty_area.Height -= valid_area.Height;
            else if (YAmount < 0)
            {
                dirty_area.Height -= valid_area.Height;
                dirty_area.Y += valid_area.Height;
            }

            if (XAmount > 0)
                dirty_area.Width -= valid_area.Width;
            else if (XAmount < 0)
            {
                dirty_area.Width -= valid_area.Width;
                dirty_area.X += valid_area.Width;
            }

            return dirty_area;
        }

        Rectangle GetTotalVisibleArea(IntPtr handle)
        {
            Control c = Control.FromHandle(handle);

            Rectangle visible_area = c.ClientRectangle;
            visible_area.Location = c.PointToScreen(Point.Empty);

            for (Control parent = c.Parent; parent != null; parent = parent.Parent)
            {
                if (!parent.IsHandleCreated || !parent.Visible)
                    return visible_area; // Non visible, not need to finish computations

                Rectangle r = parent.ClientRectangle;
                r.Location = parent.PointToScreen(Point.Empty);

                visible_area.Intersect(r);
            }

            visible_area.Location = c.PointToClient(visible_area.Location);
            return visible_area;
        }

        public override void ScrollWindow(IntPtr handle, int XAmount, int YAmount, bool with_children)
        {
            Hwnd hwnd;
            Rectangle rect;

            hwnd = Hwnd.GetObjectFromWindow(handle);

            rect = hwnd.ClientRect;
            rect.X = 0;
            rect.Y = 0;
            ScrollWindow(handle, rect, XAmount, YAmount, with_children);
        }

        public override void SendAsyncMethod(AsyncMethodData method)
        {
            Hwnd hwnd;
            XEvent xevent = new XEvent();

            hwnd = Hwnd.ObjectFromHandle(method.Handle);

     

            //WakeupMain();
        
    }

        public override int SendInput(IntPtr hwnd, Queue keys)
        {
            return 0;
        }

        delegate IntPtr WndProcDelegate(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam);

        public override IntPtr SendMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam)
        {
            Hwnd h;
            h = Hwnd.ObjectFromHandle(hwnd);

            // cross thread calls
            if (h != null && h.queue != ThreadQueue(Thread.CurrentThread))
            {
                AsyncMethodResult result;
                AsyncMethodData data;

                result = new AsyncMethodResult();
                data = new AsyncMethodData();

                data.Handle = hwnd;
                data.Method = new WndProcDelegate(NativeWindow.WndProc);
                data.Args = new object[] { hwnd, message, wParam, lParam };
                data.Result = result;

                SendAsyncMethod(data);
                // DriverDebug("Sending {0} message across.", message);

                return IntPtr.Zero;
            }
            string key = hwnd + ":" + message;
            //  if (messageHold[key] != null)
            //      messageHold[key] = ((int)messageHold[key]) - 1;
            return NativeWindow.WndProc(hwnd, message, wParam, lParam); 
        }

        public override void SetBorderStyle(IntPtr handle, FormBorderStyle border_style)
        {
            Form form = Control.FromHandle(handle) as Form;
            if (form != null && form.window_manager == null)
            {
                CreateParams cp = form.GetCreateParams();
                if (border_style == FormBorderStyle.FixedToolWindow ||
                    border_style == FormBorderStyle.SizableToolWindow ||
                    cp.IsSet(WindowExStyles.WS_EX_TOOLWINDOW))
                {
                    form.window_manager = new ToolWindowManager(form);
                }
            }

            RequestNCRecalc(handle);
        }

        public override void SetCaretPos(IntPtr hwnd, int x, int y)
        {

        }

        public override void SetClipRegion(IntPtr handle, MissionPlanner.Utilities.Drawing.Region region)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);
            if (hwnd == null)
            {
                return;
            }

            hwnd.UserClip = region;
        }

        public override void SetCursor(IntPtr hwnd, IntPtr cursor)
        {

        }

        public override void SetCursorPos(IntPtr hwnd, int x, int y)
        {
            Controls.Form.MousePosition = new Point(x, y);
        }

        public override void SetFocus(IntPtr handle)
        {
            Hwnd hwnd;
            IntPtr prev_focus_window;

            hwnd = Hwnd.ObjectFromHandle(handle);

            if (hwnd.client_window == FocusWindow)
            {
                return;
            }

            // Win32 doesn't do anything if disabled
            if (!hwnd.enabled)
                return;

            prev_focus_window = FocusWindow;
            FocusWindow = hwnd.client_window;

            if (prev_focus_window != IntPtr.Zero)
            {
                SendMessage(prev_focus_window, Msg.WM_KILLFOCUS, FocusWindow, IntPtr.Zero);
            }
            //       Keyboard.FocusIn(FocusWindow);
            SendMessage(FocusWindow, Msg.WM_SETFOCUS, prev_focus_window, IntPtr.Zero);

        }

        // Handle of the window with keyboard focus (if any)
        public override void SetIcon(IntPtr handle, Icon icon)
        {

        }

        public override void SetMenu(IntPtr handle, System.Windows.Forms.Menu menu)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);
            hwnd.menu = menu;

            RequestNCRecalc(handle);
        }

        public override void SetModal(IntPtr handle, bool Modal)
        {
            if (Modal)
            {
                ModalWindows.Push(handle);
            }
            else
            {
                if (ModalWindows.Contains(handle))
                {
                    ModalWindows.Pop();
                }
                if (ModalWindows.Count > 0)
                {
                    Activate((IntPtr)ModalWindows.Peek());
                }
            }

            Hwnd hwnd = Hwnd.ObjectFromHandle(handle);
            Control ctrl = Control.FromHandle(handle);
            //SetWMStyles(hwnd, ctrl.GetCreateParams());
            ctrl.Refresh();
        }

        public override bool SetOwner(IntPtr hWnd, IntPtr hWndOwner)
        {
            return true;
        }

        public override IntPtr SetParent(IntPtr handle, IntPtr parent)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);
            hwnd.parent = Hwnd.ObjectFromHandle(parent);

            return IntPtr.Zero;
        }

        public override void SetTimer(System.Windows.Forms.Timer timer)
        {
            XEventQueue queue = (XEventQueue)MessageQueues[timer.thread];

            if (queue == null)
            {
                // This isn't really an error, MS doesn't start the timer if
                // it has no assosciated queue at this stage (it will be
                // enabled when a window is activated).
                unattached_timer_list.Add(timer);
                return;
            }
            queue.timer_list.Add(timer);
            //WakeupMain();
        }

        public override bool SetTopmost(IntPtr hWnd, bool Enabled)
        {
            return true;
        }

        public override bool SetVisible(IntPtr handle, bool visible, bool activate)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);
            hwnd.visible = visible;
            if (visible)
            {
                SendMessage(handle, Msg.WM_WINDOWPOSCHANGED, IntPtr.Zero, IntPtr.Zero);
            }

            return true;
        }

        public override void SetWindowMinMax(IntPtr handle, System.Drawing.Rectangle maximized, System.Drawing.Size min, System.Drawing.Size max)
        {
            Control ctrl = Control.FromHandle(handle);
           // SetWindowMinMax(handle, maximized, min, max, ctrl != null ? ctrl.GetCreateParams() : null);
        }

        public override void SetWindowPos(IntPtr handle, int x, int y, int width, int height)
        {

            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);

            if (hwnd == null)
            {
                return;
            }

            // Win32 automatically changes negative width/height to 0.
            if (width < 0)
                width = 0;
            if (height < 0)
                height = 0;

            // X requires a sanity check for width & height; otherwise it dies
            if (hwnd.zero_sized && width > 0 && height > 0)
            {
                if (hwnd.visible)
                {
                    hwnd.Mapped = true;
                    //MapWindow(hwnd, WindowType.Whole);
                }
                hwnd.zero_sized = false;
            }

            if ((width < 1) || (height < 1))
            {
                hwnd.zero_sized = true;
                //UnmapWindow(hwnd, WindowType.Whole);
            }

            // Save a server roundtrip (and prevent a feedback loop)
            if ((hwnd.x == x) && (hwnd.y == y) &&
                (hwnd.width == width) && (hwnd.height == height))
            {
                return;
            }

            hwnd.x = x;
            hwnd.y = y;
            hwnd.width = width;
            hwnd.height = height;
            SendMessage(hwnd.client_window, Msg.WM_WINDOWPOSCHANGED, IntPtr.Zero, IntPtr.Zero);

            if (!hwnd.zero_sized)
            {
                if (hwnd.fixed_size)
                {
                    SetWindowMinMax(handle, Rectangle.Empty, new Size(width, height), new Size(width, height));
                }

                //   lock (XlibLock)
                {
                    Control ctrl = Control.FromHandle(handle);
                    //Size TranslatedSize = TranslateWindowSizeToXWindowSize(ctrl.GetCreateParams(), new Size(width, height));
                    //MoveResizeWindow(DisplayHandle, hwnd.whole_window, x, y, TranslatedSize.Width, TranslatedSize.Height);
                    PerformNCCalc(hwnd);
                }
            }

            // Update our position/size immediately, so
            // that future calls to SetWindowPos aren't
            // kept from calling XMoveResizeWindow (by the
            // "Save a server roundtrip" block above).
            hwnd.x = x;
            hwnd.y = y;
            hwnd.width = width;
            hwnd.height = height;
            hwnd.ClientRect = Rectangle.Empty;
        }

        public override void SetWindowState(IntPtr handle, FormWindowState state)
        {

        }

        public override void SetWindowStyle(IntPtr handle, CreateParams cp)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);
            SetHwndStyles(hwnd, cp);
            SetWMStyles(hwnd, cp);
        }

        void SetHwndStyles(Hwnd hwnd, CreateParams cp)
        {
            DeriveStyles(cp.Style, cp.ExStyle, out hwnd.border_style, out hwnd.border_static, out hwnd.title_style, out hwnd.caption_height, out hwnd.tool_caption_height);
        }

        void DeriveStyles(int Style, int ExStyle, out FormBorderStyle border_style, out bool border_static, out TitleStyle title_style, out int caption_height, out int tool_caption_height)
        {

            caption_height = 0;
            tool_caption_height = 19;
            border_static = false;

            if (StyleSet(Style, WindowStyles.WS_CHILD))
            {
                if (ExStyleSet(ExStyle, WindowExStyles.WS_EX_CLIENTEDGE))
                {
                    border_style = FormBorderStyle.Fixed3D;
                }
                else if (ExStyleSet(ExStyle, WindowExStyles.WS_EX_STATICEDGE))
                {
                    border_style = FormBorderStyle.Fixed3D;
                    border_static = true;
                }
                else if (!StyleSet(Style, WindowStyles.WS_BORDER))
                {
                    border_style = FormBorderStyle.None;
                }
                else
                {
                    border_style = FormBorderStyle.FixedSingle;
                }
                title_style = TitleStyle.None;

                if (StyleSet(Style, WindowStyles.WS_CAPTION))
                {
                    caption_height = 19;
                    if (ExStyleSet(ExStyle, WindowExStyles.WS_EX_TOOLWINDOW))
                    {
                        title_style = TitleStyle.Tool;
                    }
                    else
                    {
                        title_style = TitleStyle.Normal;
                    }
                }

                if (ExStyleSet(ExStyle, WindowExStyles.WS_EX_MDICHILD))
                {
                    caption_height = 19;

                    if (StyleSet(Style, WindowStyles.WS_OVERLAPPEDWINDOW) ||
                        ExStyleSet(ExStyle, WindowExStyles.WS_EX_TOOLWINDOW))
                    {
                        border_style = (FormBorderStyle)0xFFFF;
                    }
                    else
                    {
                        border_style = FormBorderStyle.None;
                    }
                }

            }
            else
            {
                title_style = TitleStyle.None;
                if (StyleSet(Style, WindowStyles.WS_CAPTION))
                {
                    if (ExStyleSet(ExStyle, WindowExStyles.WS_EX_TOOLWINDOW))
                    {
                        title_style = TitleStyle.Tool;
                    }
                    else
                    {
                        title_style = TitleStyle.Normal;
                    }
                }

                border_style = FormBorderStyle.None;

                if (StyleSet(Style, WindowStyles.WS_THICKFRAME))
                {
                    if (ExStyleSet(ExStyle, WindowExStyles.WS_EX_TOOLWINDOW))
                    {
                        border_style = FormBorderStyle.SizableToolWindow;
                    }
                    else
                    {
                        border_style = FormBorderStyle.Sizable;
                    }
                }
                else
                {
                    if (StyleSet(Style, WindowStyles.WS_CAPTION))
                    {
                        if (ExStyleSet(ExStyle, WindowExStyles.WS_EX_CLIENTEDGE))
                        {
                            border_style = FormBorderStyle.Fixed3D;
                        }
                        else if (ExStyleSet(ExStyle, WindowExStyles.WS_EX_STATICEDGE))
                        {
                            border_style = FormBorderStyle.Fixed3D;
                            border_static = true;
                        }
                        else if (ExStyleSet(ExStyle, WindowExStyles.WS_EX_DLGMODALFRAME))
                        {
                            border_style = FormBorderStyle.FixedDialog;
                        }
                        else if (ExStyleSet(ExStyle, WindowExStyles.WS_EX_TOOLWINDOW))
                        {
                            border_style = FormBorderStyle.FixedToolWindow;
                        }
                        else if (StyleSet(Style, WindowStyles.WS_BORDER))
                        {
                            border_style = FormBorderStyle.FixedSingle;
                        }
                    }
                    else
                    {
                        if (StyleSet(Style, WindowStyles.WS_BORDER))
                        {
                            border_style = FormBorderStyle.FixedSingle;
                        }
                    }
                }
            }
        }

        void SetWMStyles(Hwnd hwnd, CreateParams cp)
        {
            
        }

        public override void SetWindowTransparency(IntPtr handle, double transparency, System.Drawing.Color key)
        {

        }

        public override bool SetZOrder(IntPtr hWnd, IntPtr AfterhWnd, bool Top, bool Bottom)
        {
            return true;
        }

        public override void ShowCursor(bool show)
        {

        }

        public override void ShutdownDriver(IntPtr token)
        {

        }

        public override object StartLoop(Thread thread)
        {
            XEventQueue q = ThreadQueue(thread);
            return q;
        }

        public override TransparencySupport SupportsTransparency()
        {
            return TransparencySupport.None;
        }

        public override bool SystrayAdd(IntPtr hwnd, string tip, Icon icon, out ToolTip tt)
        {
            tt = new ToolTip();
            return false;
        }

        public override void SystrayBalloon(IntPtr hwnd, int timeout, string title, string text, ToolTipIcon icon)
        {

        }

        public override bool SystrayChange(IntPtr hwnd, string tip, Icon icon, ref ToolTip tt)
        {
            return false;
        }

        public override void SystrayRemove(IntPtr hwnd, ref ToolTip tt)
        {

        }

        public override bool Text(IntPtr handle, string text)
        {
            return true;
        }

        public override bool TranslateMessage(ref MSG msg)
        {
            return true;
        }

        public override void UngrabWindow(IntPtr hwnd)
        {

        }

        public override void UpdateWindow(IntPtr handle)
        {
            Hwnd hwnd;

            hwnd = Hwnd.ObjectFromHandle(handle);

            if (!hwnd.visible || !hwnd.expose_pending || !hwnd.Mapped)
            {
                return;
            }

            SendMessage(handle, Msg.WM_PAINT, IntPtr.Zero, IntPtr.Zero);
            hwnd.Queue.Paint.Remove(hwnd);
        }

        void CheckTimers(ArrayList timers, DateTime now)
        {
            int count;

            count = timers.Count;

            if (count == 0)
                return;

            for (int i = 0; i < timers.Count; i++)
            {
                Timer timer;

                timer = (Timer)timers[i];

                if (timer.Enabled && timer.Expires <= now && !timer.Busy)
                {
                    // Timer ticks:
                    //  - Before MainForm.OnLoad if DoEvents () is called.
                    //  - After MainForm.OnLoad if not.
                    //
                    if (in_doevents ||
                        (Application.MWFThread.Current.Context != null &&
                         (Application.MWFThread.Current.Context.MainForm == null ||
                          Application.MWFThread.Current.Context.MainForm.IsLoaded)))
                    {
                        timer.Busy = true;
                        timer.Update(now);
                        timer.FireTick();
                        timer.Busy = false;
                    }
                }
            }
        }

        void AddExpose(Hwnd hwnd, bool client, int x, int y, int width, int height)
        {
            // Don't waste time
            if ((hwnd == null) || (x > hwnd.Width) || (y > hwnd.Height) || ((x + width) < 0) || ((y + height) < 0))
            {
                return;
            }

            // Keep the invalid area as small as needed
            if ((x + width) > hwnd.width)
            {
                width = hwnd.width - x;
            }

            if ((y + height) > hwnd.height)
            {
                height = hwnd.height - y;
            }

            if (client)
            {
                hwnd.AddInvalidArea(x, y, width, height);
                if (!hwnd.expose_pending)
                {
                    if (!hwnd.nc_expose_pending)
                    {
                        hwnd.Queue.Paint.Enqueue(hwnd);
                    }
                    hwnd.expose_pending = true;
                }
            }
            else
            {
                hwnd.AddNcInvalidArea(x, y, width, height);

                if (!hwnd.nc_expose_pending)
                {
                    if (!hwnd.expose_pending)
                    {
                        var ctl = System.Windows.Forms.Control.ControlNativeWindow.ControlFromHandle(hwnd.Handle);
                        //      ctl.InvokePaint(ctl,
                        //         new PaintEventArgs(Graphics.FromImage(new Bitmap(ctl.Width, ctl.Height)),
                        //             System.Drawing.Rectangle.FromLTRB(0, 0, ctl.Width, ctl.Height)));
                        // var paint = new Message() {Msg = (int) Msg.WM_PAINT, HWnd = hwnd.Handle};
                        // ctl.WndProcDOIT(ref paint);



                        hwnd.Queue.Paint.Enqueue(hwnd);
                    }
                    hwnd.nc_expose_pending = true;
                }
            }
        }

        bool ExStyleSet(int ex, WindowExStyles exws)
        {
            return (ex & (int)exws) == (int)exws;
        }

        void PerformNCCalc(Hwnd hwnd)
        {
            NCCALCSIZE_PARAMS ncp;
            IntPtr ptr;
            Rectangle rect;

            rect = new Rectangle(0, 0, hwnd.Width, hwnd.Height);

            ncp = new NCCALCSIZE_PARAMS();
            ptr = Marshal.AllocHGlobal(Marshal.SizeOf(ncp));

            ncp.rgrc1.left = rect.Left;
            ncp.rgrc1.top = rect.Top;
            ncp.rgrc1.right = rect.Right;
            ncp.rgrc1.bottom = rect.Bottom;

            Marshal.StructureToPtr(ncp, ptr, true);
            NativeWindow.WndProc(hwnd.client_window, Msg.WM_NCCALCSIZE, (IntPtr)1, ptr);
            ncp = (NCCALCSIZE_PARAMS)Marshal.PtrToStructure(ptr, typeof(NCCALCSIZE_PARAMS));
            Marshal.FreeHGlobal(ptr);


            rect = new Rectangle(ncp.rgrc1.left, ncp.rgrc1.top, ncp.rgrc1.right - ncp.rgrc1.left, ncp.rgrc1.bottom - ncp.rgrc1.top);
            hwnd.ClientRect = rect;

            //   rect = TranslateClientRectangleToXClientRectangle(hwnd);

            if (hwnd.visible)
            {
                //  MoveResizeWindow(DisplayHandle, hwnd.client_window, rect.X, rect.Y, rect.Width, rect.Height);
            }

            AddExpose(hwnd, hwnd.WholeWindow == hwnd.ClientWindow, 0, 0, hwnd.Width, hwnd.Height);
        }

        bool StyleSet(int s, WindowStyles ws)
        {
            return (s & (int)ws) == (int)ws;
        }
             // Holds our thread-specific XEventQueues
        XEventQueue ThreadQueue(Thread thread)
        {
            XEventQueue queue;

            queue = (XEventQueue)MessageQueues[thread];
            if (queue == null)
            {
                queue = new XEventQueue(thread);
                MessageQueues[thread] = queue;
            }

            return queue;
        }
    }
}