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

namespace ControlTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LogInPage LogInPage;
        SignUpPage SignUpPage;
        UserPage UserPage;
        public MainWindow()
        {
            InitializeComponent();
            LogInPage = new LogInPage();
            SignUpPage = new SignUpPage();
            UserPage = new UserPage();
            mainFrame.NavigationService.Navigate(LogInPage, UriKind.Relative);
        }

        
    }
}
