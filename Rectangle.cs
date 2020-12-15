using System;
using System.Windows;
using System.IO;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.Windows.Input;

namespace WpfApp1
{
    class Rectangle
    {
        Point TopLeft;
        Point TopRight;
        Point LowerLeft;
        Point LowerRight;
        public Stroke Outline;
        
        public Rectangle(Point TopPnt, Point LowerPnt, Color color)
        {

            if(TopPnt.X<LowerPnt.X)
            {
                TopLeft = TopPnt;
                TopRight = new Point(LowerPnt.X, TopPnt.Y);
                LowerLeft = new Point(TopPnt.X, LowerPnt.Y);
                LowerRight = LowerPnt;

            }
            else
            {
                TopRight = TopPnt;
                TopLeft = new Point(LowerPnt.X, TopPnt.Y);
                LowerRight = new Point(TopRight.X, LowerPnt.Y);
                LowerLeft = LowerPnt;

             

            }
            StylusPointCollection pts = new StylusPointCollection();

            pts.Add(new StylusPoint(TopLeft.X, TopLeft.Y));

            pts.Add(new StylusPoint(TopRight.X, TopRight.Y));

            pts.Add(new StylusPoint(LowerRight.X, LowerRight.Y));

            pts.Add(new StylusPoint(LowerLeft.X, LowerLeft.Y));

            pts.Add(new StylusPoint(TopLeft.X, TopLeft.Y));

            Outline = new Stroke(pts);

            Outline.DrawingAttributes.Color = color;

        }

        
    }
}
