using System;
using System.Collections.Generic;
using System.IO.Pipes;
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

namespace GridLesson1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            char[] arr = { '!', '@', '*', '_', '?', '-', '.' };
            string ran = arr.ToString();

            if (txtPassword.Password.Length < 8 || !txtPassword.Password.Contains(ran))
            { 
                MessageBox.Show("You have not fulfilled one or more password requirements. Try again.", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            
            }

            else
            {

                MessageBox.Show($"Success. Your Username is {txtUsername.Text} and your password is {txtPassword.Password}");
               
            }

                
                
                
                
                }

        private void ClearU(object sender, RoutedEventArgs e)
        {
            txtUsername.Text = " ";
        }

        private void ClearFN(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = " ";
        }

        private void ClearLN(object sender, RoutedEventArgs e)
        {
            txtLastName.Text = " ";
        }

        private void ClearE(object sender, RoutedEventArgs e)
        {
            txtEmail.Text = " ";
        }
    }
}
