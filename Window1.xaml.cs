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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

      

        private void UseKeyButton_Click(object sender, RoutedEventArgs e)
        {
            DataBaseConnector dataBaseConnector = new DataBaseConnector("LicenseKey");
            try
            {
                dataBaseConnector.Keys.Add(new LicenseKey {Id=1, Key = "trial" });
            }
            catch(Exception exp) { }        

            if (dataBaseConnector.Had(LicenseKeyTextBox.Text))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
                SetAuthorize(true);

            }
            else
            {
                MessageBox.Show("Invalid License Key");
            }

        }

        private void SetAuthorize(bool v)
        {
            using (System.IO.StreamWriter file =
             new System.IO.StreamWriter("athorize.txt"))
            {                                
                        file.WriteLine(v.ToString());                
            }
        }
    }
}
