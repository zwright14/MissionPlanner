using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MissionPlanner;
using MissionPlanner.Antenna;
using MissionPlanner.Controls;
using MissionPlanner.GCSViews;
using MissionPlanner.Utilities;
using MissionPlanner.Utilities.Drawing;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using Application = System.Windows.Forms.Application;
using Brushes = MissionPlanner.Utilities.Drawing.Brushes;
using Color = System.Drawing.Color;
using Form = System.Windows.Forms.Form;
using Graphics = MissionPlanner.Utilities.Drawing.Graphics;
using Image = MissionPlanner.Utilities.Drawing.Image;
using MouseButtons = MissionPlanner.Utilities.Drawing.MouseButtons;
using Pen = MissionPlanner.Utilities.Drawing.Pen;
using Point = System.Drawing.Point;
using StringFormat = MissionPlanner.Utilities.Drawing.StringFormat;
using SystemFonts = MissionPlanner.Utilities.Drawing.SystemFonts;

namespace Xamarin
{
    public partial class FlightData : ContentPage
    {
      

        public FlightData()
        {
            InitializeComponent();

            GMap.NET.GMaps.Instance.PrimaryCache = new MissionPlanner.Maps.MyImageCache();

            track = new MissionPlanner.GCSViews.FlightData();

            SkglView.SizeChanged += FlightPlanner_OnSizeChanged;

            ((MissionPlanner.GCSViews.FlightData)track).gMapControl1.MapProvider = GMapProviders.BingSatelliteMap;

            track.CreateControl();
        }
        
        private void SKGLView_OnPaintSurface(object sender, SKPaintGLSurfaceEventArgs e)
        {


            e.Surface.Canvas.Clear(SKColors.AliceBlue);

            e.Surface.Canvas.DrawRect(10, 10, 50, 50, new SKPaint() {StrokeWidth = 2, Color = SKColors.Red});

            e.Surface.Canvas.DrawText(touchpoint.ToString(), 80, 20, new SKPaint() {TextSize = 16, StrokeWidth = 2});

            var g = new Graphics(e.Surface);



            g.DrawRectangle(new Pen(Color.Red), touchpoint.X, touchpoint.Y, 12, 12);



            e.Surface.Canvas.DrawText(base.Width + " " + base.Height, 80, 40,
                new SKPaint() {TextSize = 16, StrokeWidth = 2});

            e.Surface.Canvas.DrawText(SkglView.CanvasSize.ToString(), 80, 60,
                new SKPaint() {TextSize = 16, StrokeWidth = 2});

            {
                
                var pe = new PaintEventArgs(g /*Graphics.FromImage(new Bitmap(frm.Width, frm.Height))*/,
                    System.Drawing.Rectangle.FromLTRB(0, 0, (int)SkglView.CanvasSize.Width, (int)SkglView.CanvasSize.Height));

              //  frm.InvokePaint(frm,pe)

              track.Size = new System.Drawing.Size((int) SkglView.CanvasSize.Width, (int) SkglView.CanvasSize.Height);

                Queue<Control> list = new Queue<Control>();

            
                // seed this list
                list.Enqueue(track);

                Func<Control, Point> traverse = null;
                traverse = (n) =>
                {
                    if (n.Parent == null) return new Point(n.Location.X, n.Location.Y);
                    var ans = traverse(n.Parent);
                    return new Point(n.Location.X + ans.X, n.Location.Y + ans.Y);
                };

                System.Diagnostics.Debug.WriteLine(track + " " + track.Name + " START" );
                while (list.Count > 0)
                {
                    var item = list.Dequeue();
                    /*
                    if (item.Parent != null)
                        pe.SetClip(new System.Drawing.Rectangle(traverse(item), new System.Drawing.Size(item.Width, item.Height)));
                    pe.Graphics.ResetTransform();
                    var pos = traverse(item);
                    pe.Graphics.TranslateTransform(pos.X, pos.Y);
                    System.Diagnostics.Debug.WriteLine(item + " " + item.Name + " " + pos);

                    item.DrawToGraphics(pe.Graphics, pe.ClipRectangle);
                    

                    */
                    try
                    {
                        var pos = traverse(item);

                    var g2 = new Graphics(IntPtr.Zero, item.Width, item.Height);
                    item.DrawToGraphics(g2,
                        new System.Drawing.Rectangle(0, 0, item.Width, item.Height));
               
                     //   ((Image)g2).Save(Path.GetTempPath() + item.Name + "1.jpg");
              

                    g.DrawImage(g2, pos.X, pos.Y);
                    }
                    catch { }

                    item.Controls.ForEach<Control>(a => list.Enqueue(a));
                }
            }

            g.ResetTransform();
            g.DrawRectangle(new Pen(Color.Red), touchpoint.X, touchpoint.Y, 12, 12);


            e.Surface.Canvas.Flush();

        }

        private Control track;
        private SKPoint touchpoint = SKPoint.Empty; private Dictionary<long, SKPath> temporaryPaths = new Dictionary<long, SKPath>();
        private double mousewheeldelta = 0;

        private void SkglView_OnTouch(object sender, SKTouchEventArgs e)
        {
            touchpoint = e.Location;


            XplatUI.driver.SetCursorPos(IntPtr.Zero, (int)e.Location.X, (int)e.Location.Y);

            Func<Control, Point> traverse = null;
            traverse = (n) =>
            {
                if (n.Parent == null) return new Point(n.Location.X, n.Location.Y);
                var ans = traverse(n.Parent);
                return new Point(n.Location.X + ans.X, n.Location.Y + ans.Y);
            };

            var child = track.GetChildAtPoint(new Point((int)e.Location.X, (int)e.Location.Y));

            if (child == null || child.Handle == null)
                return;

            Point pos;

            while (true)
            {
                pos = traverse(child);

                var tmp = child.GetChildAtPoint(new Point((int)e.Location.X - pos.X, (int)e.Location.Y - pos.Y));
                if (tmp == null)
                    break;
                child = tmp;
            }

            if (child == null || child.Handle == null)
                return;

            if (e.ActionType == SKTouchAction.Pressed)
            {
            }

            var mouse = new MouseEventArgs()
            {
                X = (int)e.Location.X - pos.X,
                Y = (int)e.Location.Y - pos.Y,
                Button = (System.Windows.Forms.MouseButtons)(e.MouseButton == SKMouseButton.Left ? MouseButtons.Left :
                    e.MouseButton == SKMouseButton.Unknown ? MouseButtons.None :
                    e.MouseButton == SKMouseButton.Right ? MouseButtons.Right : MouseButtons.Middle),
                Delta = 0 // mouse wheel
            };

            // pinching - multiple paths at once
            if (temporaryPaths.Count > 1)
            {
                //System.Diagnostics.Debug.WriteLine(temporaryPaths.ToJSON());

                var key1 = temporaryPaths.Keys.ElementAt(0);
                var key2 = temporaryPaths.Keys.ElementAt(1);

                var startdist = temporaryPaths[key1].Points.First() - temporaryPaths[key2].Points.First();
                var enddist = temporaryPaths[key1].Points.Last() - temporaryPaths[key2].Points.Last();

                var delta = enddist - startdist;



                //tru is smaller
                //System.Diagnostics.Debug.WriteLine(delta + " " + delta.Length + " " + (startdist.Length > enddist.Length));

                var m1 = new SKPoint(temporaryPaths[key1].Bounds.MidX, temporaryPaths[key1].Bounds.MidY);
                var m2 = new SKPoint(temporaryPaths[key2].Bounds.MidX, temporaryPaths[key2].Bounds.MidY);

                var mid = m1 - m2;

                mouse.X = (int)(m2.X + mid.X / 2.0);
                mouse.Y = (int)(m2.Y + mid.Y / 2.0);

                // set it only after length movement
                if (delta.Length > mousewheeldelta + 10 || delta.Length < mousewheeldelta - 10)
                {
                    mouse.Delta = (startdist.Length > enddist.Length) ? -1 : 1;

                    System.Diagnostics.Debug.WriteLine(delta + " " + delta.Length + " " +
                                                       (startdist.Length > enddist.Length) + " " +
                                                       ((startdist.Length > enddist.Length) ? -1 : 1));


                    mousewheeldelta = delta.Length;
                }

                XplatUI.driver.SendMessage(child.Handle, Msg.WM_MOUSEWHEEL, GetMousewParam(mouse),
                   (IntPtr)(mouse.Y << 16 | mouse.X & 0xFFFF));
                //track.OnMouseWheel(mouse);
            }
            else
            {
                if (e.ActionType == SKTouchAction.Entered)
                {
                    XplatUI.driver.SendMessage(child.Handle, Msg.WM_MOUSE_ENTER, GetMousewParam(mouse),
                        (IntPtr)(mouse.Y << 16 | mouse.X & 0xFFFF));
                    //track.OnMouseEnter(null);
                }

                if (e.ActionType == SKTouchAction.Moved)
                {

                    XplatUI.driver.SendMessage(child.Handle, Msg.WM_MOUSEMOVE, GetMousewParam(mouse),
                        (IntPtr)(mouse.Y << 16 | mouse.X & 0xFFFF));
                    //track.OnMouseMove(mouse);
                }

                if (e.ActionType == SKTouchAction.Pressed)
                {

                    XplatUI.driver.SendMessage(child.Handle, mouse.Button == System.Windows.Forms.MouseButtons.Left ? Msg.WM_LBUTTONDOWN : Msg.WM_RBUTTONDOWN, GetMousewParam(mouse),
                        (IntPtr)(mouse.Y << 16 | mouse.X & 0xFFFF));
                    //track.OnMouseDown(mouse);
                }

                if (e.ActionType == SKTouchAction.Released)
                {
                    XplatUI.driver.SendMessage(child.Handle, mouse.Button == System.Windows.Forms.MouseButtons.Left ? Msg.WM_LBUTTONUP : Msg.WM_RBUTTONUP, GetMousewParam(mouse),
                        (IntPtr)(mouse.Y << 16 | mouse.X & 0xFFFF));
                    //track.OnMouseUp(mouse);
                    //track.OnMouseClick(mouse);
                }



                if (e.ActionType == SKTouchAction.Exited)
                {
                    XplatUI.driver.SendMessage(track.Handle, Msg.WM_MOUSELEAVE, GetMousewParam(mouse),
                        (IntPtr)(mouse.Y << 16 | mouse.X & 0xFFFF));
                    //track.OnMouseLeave(null);
                }
            }

            switch (e.ActionType)
            {
                case SKTouchAction.Pressed:
                    // start of a stroke
                    var p = new SKPath();
                    p.MoveTo(e.Location);
                    temporaryPaths[e.Id] = p;
                    track.Invalidate();
                    break;
                case SKTouchAction.Moved:
                    // the stroke, while pressed
                    if (e.InContact)
                        temporaryPaths[e.Id].LineTo(e.Location);
                    break;
                case SKTouchAction.Released:
                    // end of a stroke
                    //paths.Add(temporaryPaths[e.Id]);
                    temporaryPaths.Remove(e.Id);
                    track.Invalidate();
                    break;
                case SKTouchAction.Cancelled:
                    // we don't want that stroke
                    temporaryPaths.Remove(e.Id);
                    break;
            }

            //System.Diagnostics.Debug.WriteLine(e.ToJSON());

            SkglView.InvalidateSurface();

            // we have handled these events
            e.Handled = true;
        }

        private IntPtr GetMousewParam(MouseEventArgs i)
        {
            int result = 0;
            if (((int)i.Button & (int)MouseButtons.Left) != 0)
            {
                result |= (int)MsgButtons.MK_LBUTTON;
            }

            if (((int)i.Button & (int)MouseButtons.Middle) != 0)
            {
                result |= (int)MsgButtons.MK_MBUTTON;
            }

            if (((int)i.Button & (int)MouseButtons.Right) != 0)
            {
                result |= (int)MsgButtons.MK_RBUTTON;
            }

            result |= i.Delta << 16;

            return (IntPtr)result;
        }

        private void FlightPlanner_OnSizeChanged(object sender, EventArgs e)
        {
            try
            {
                track.Size = new System.Drawing.Size((int) SkglView.CanvasSize.Width, (int) SkglView.CanvasSize.Height);
        track.PerformLayout();

            SkglView.InvalidateSurface();
            }
            catch { }
        }
    }
}