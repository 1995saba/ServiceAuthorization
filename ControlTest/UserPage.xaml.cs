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
using AppModels;
using Newtonsoft.Json;
using AppData;

namespace ControlTest
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        DataBase dataBase = new DataBase();
        User currentUser = new User();
        public UserPage()
        {
            InitializeComponent();
            //user.Text=(dataBase.Deserializer(currentUser)).ToString();
        }
    }
}
