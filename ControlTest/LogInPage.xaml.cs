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
using AppServices;
using AppModels;

namespace ControlTest
{
    /// <summary>
    /// Логика взаимодействия для LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        EmailSender emailSender;
        User currentUser = new User();
        Authorization authorization = new Authorization();
        public LogInPage()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            

            NavigationService.Navigate(new Uri("UserPage.xaml", UriKind.Relative));
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("SignUpPage.xaml", UriKind.Relative));
        }

        private void ForgotPasswordLabel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("На Вашу почту отправлен пароль для авторизации");
            emailSender = new EmailSender();
            emailSender.Send(currentUser.Email, "Новый пароль", "Ваш новый пароль: "+currentUser.Password);
        }
    }
}
