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

namespace SocialNetwork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register_Form register_Form = new Register_Form();
            register_Form.Show();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if(loginTextBlock.Text == "coursework")
            {
                if(passwordBox.Password == "1111")
                {
                    MessageBox.Show("OK", "Success", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                }
            }
        }
    }
}
