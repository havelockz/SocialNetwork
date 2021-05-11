using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            MessageBox.Show("Settings already in developing", "ops", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void informationButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Курсову роботу виконав: Радченко Микола 20 курс", "WARNING!", MessageBoxButton.OK, MessageBoxImage.Warning,MessageBoxResult.OK,MessageBoxOptions.ServiceNotification);
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
            ButtonCloseMessagingMenu.Visibility = Visibility.Visible;
            ButtonOpenMessagingMenu.Visibility = Visibility.Collapsed;
        }

        private void messagesButton_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Visibility = Visibility.Hidden;
            GridSettings.Visibility = Visibility.Hidden;
            GridMessaging.Visibility = Visibility.Visible;
        }

        private void photosButton_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Visibility = Visibility.Hidden;
            GridSettings.Visibility = Visibility.Visible;
            GridMessaging.Visibility = Visibility.Hidden;
        }

        private void ButtonCloseSettingsMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseSettingsMenu.Visibility = Visibility.Hidden;
            ButtonOpenSettingsMenu.Visibility = Visibility.Visible;
        }

        private void ButtonOpenSettingsMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseSettingsMenu.Visibility = Visibility.Visible;
            ButtonOpenSettingsMenu.Visibility = Visibility.Hidden;
        }

        private void openServeClientButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"Chat\SocketChat.exe");
            Process.Start(@"Chat\SocketChat.exe");
        }
    }
}
