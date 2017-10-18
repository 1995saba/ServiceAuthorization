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
using AppData;

namespace ControlTest
{
    /// <summary>
    /// Логика взаимодействия для LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        private EmailSender emailSender;
        private User currentUser;
        private Authorization authorization;
        private UserPage userPage;
        private DataBase dataBase;

        public LogInPage()
        {
            InitializeComponent();
            currentUser = new User();
            authorization = new Authorization();
            userPage = new UserPage();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            if (!((loginTextBox.Text == "") || (passwordTextBox.Text == "")))
            {
                if (loginTextBox.Text[0] >= '0' && loginTextBox.Text[0] <= '9')
                {
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                    incorrectPasswordTextBlock.Visibility=Visibility.Visible;
                }

                userPage.CurrentUser = authorization.AuthorityVerify(loginTextBox.Text, passwordTextBox.Text);
                if (userPage.CurrentUser != null)
                {
                    NavigationService.Navigate(userPage);
                    userPage.loginTextBlock.Text = currentUser.Login;
                }
                else
                {
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                    incorrectPasswordTextBlock.Visibility = Visibility.Visible;
                }
            }  
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
