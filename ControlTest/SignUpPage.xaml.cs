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
using AppData;
using AppModels;

namespace ControlTest
{
    /// <summary>
    /// Логика взаимодействия для SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        private DataBase dataBase;
        private UserPage userPage;

        public SignUpPage()
        {
            InitializeComponent();
            userPage = new UserPage();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text,
                Email = emailTextBox.Text,
                OtherInfo = otherInfoRichTextBox.ToString()
            };
            dataBase.AddUser(user);
            userPage.CurrentUser = user;
            userPage.loginTextBlock.Text = user.Login;
            NavigationService.Navigate(userPage);
        }
    }
}
