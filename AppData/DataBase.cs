using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModels;
using Newtonsoft.Json;
using System.IO;

namespace AppData
{
    public class DataBase
    {
        private List<User> users;
        private User admin;
        public DataBase()
        {
            users = new List<User>();
            admin = new User()
            {
                Login = "admin",
                Password = "qwerty123",
                Email = "sabina.orunbaeva@gmail.com",
                OtherInfo = "ляляля"
            };
            using(FileStream fs = new FileStream("users.json", FileMode.OpenOrCreate))
            {
                JsonConvert.SerializeObject(admin);
            }
            
            users.Add(admin);
        }

        public void AddUser(User user)
        {
            user = new User();
            JsonConvert.SerializeObject(user);
            this.users.Add(user);
        }

        public User GetUser(string login)
        {
            foreach (var user in users)
            {
                if (user.Login == login)
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}
