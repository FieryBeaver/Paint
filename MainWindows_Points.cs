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
    public partial class MainWindow
    {
        Point TopPnt;
        Point LowerPnt;
        private void AddTopPoints(object sender, MouseEventArgs e)
        {
            TopPnt = e.GetPosition(inkCanvas1);
            
        }

        private void AddLowerPoints(object sender, MouseButtonEventArgs e)
        {
            LowerPnt = e.GetPosition(inkCanvas1);
            if (LowerPnt.Y < TopPnt.Y) SwapPoints(LowerPnt, TopPnt);
            
                        
        }

        private void SwapPoints(Point lowerPnt, Point topPnt)
        {
           
            var tmp = new Point(LowerPnt.X,lowerPnt.Y);
            lowerPnt = new Point(TopPnt.X, TopPnt.Y);
            topPnt = tmp;

            

        }
    }
}
