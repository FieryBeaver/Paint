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

        enum Tools
        {
            Shapes,
            Eraser,
            Select,
            Pen,
            None

        }


        enum Shapes
        {
            Elips,
            Squere,
            Line,

        }


        private Tools CurrentTool { get; set; }=Tools.None;



        private void ToolsOpen_Click(object sender, RoutedEventArgs e)
        {
            Palette obj = new Palette();
            obj.Show();
        }

        private void Rectangle_Click(object sender, RoutedEventArgs e)
        {
            CurrentTool = Tools.Shapes;
            inkCanvas1.EditingMode = InkCanvasEditingMode.None;

        }


        private void Ereser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pen_Click(object sender, RoutedEventArgs e)
        {
            CurrentTool=Tools.Pen;
            inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
        }



        private void EresePoint_Click(object sender, RoutedEventArgs e)
        {
            CurrentTool = Tools.Eraser;
            inkCanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void EreseStroke_Click(object sender, RoutedEventArgs e)
        {
            CurrentTool = Tools.Eraser;
            inkCanvas1.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            CurrentTool = Tools.Select;
            inkCanvas1.EditingMode = InkCanvasEditingMode.Select;

        }


    }
}
