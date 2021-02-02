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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LBLmsg.Content = string.Empty;
            txtfavnum.Clear();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("You clicked me!");

            MessageBox.Show("Thanks for clicking me!", "Clicked", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            LBLmsg.Content = "Hello World!";

            string answer = txtfavnum.Text;
            double result = Convert.ToDouble(answer);

            lbloutput.Content = $"Your favorite number mulitplied by 5 is {(result * 5).ToString("N2")}!";
        }

        private void btnclose_Click (object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("You clicked me!");
            MessageBox.Show("Hahha you clicked me");
            Environment.Exit(0);
           
        }
    }
}
