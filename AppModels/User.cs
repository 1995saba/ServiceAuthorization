using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public class User
    {
        private int id=0;
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string OtherInfo { get; set; }

        public User()
        {
            id++;
        }
    }
}
