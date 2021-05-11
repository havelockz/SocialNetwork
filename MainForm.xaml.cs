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

namespace SocialNetwork
{
    /// <summary>
    /// Логика взаимодействия для MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void secondLikeButton_Click(object sender, RoutedEventArgs e)
        {
            secondHeartIcon.Foreground = new SolidColorBrush(Colors.Red);
            secondCountOfLikes.Content = "877";
            secondLikeButton.IsEnabled = false;
        }

        private void firstLikeBottun_Click(object sender, RoutedEventArgs e)
        {
            firstLikeIcon.Foreground = new SolidColorBrush(Colors.Red);
            firstCountOfLikes.Content = "679";
            firstLikeBottun.IsEnabled = false;
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void informationButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void homeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Visibility = Visibility.Visible;
            GridSettings.Visibility = Visibility.Hidden;
            GridMessaging.Visibility = Visibility.Hidden;
        }

        private void ButtonCloseMessagingMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMessagingMenu.Visibility = Visibility.Visible;
            ButtonCloseMessagingMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMessagingMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMessagingMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMessagingMenu.Visibility = Visibility.Visible;
        }

        private void sendMessageButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
