using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System;
using System.IO;
using System.Text;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Loading.xaml
    /// </summary>
    public partial class Loading : Window
    {
        public Loading()
        {
            InitializeComponent();
            getAuthorize();

        }

        private void getAuthorize()
        {
            if(isAuthorize())
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                Window1 mainWindow = new Window1();
                mainWindow.Show();
                this.Close();
                
            }
        }

        private bool isAuthorize()
        {
            return File.ReadAllText("athorize.txt")!="";
        }
    }
}
