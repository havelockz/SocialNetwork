﻿using System;
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

namespace SocialNetwork
{
    /// <summary>
    /// Логика взаимодействия для Register_Form.xaml
    /// </summary>
    public partial class Register_Form : Window
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void loginRegButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
