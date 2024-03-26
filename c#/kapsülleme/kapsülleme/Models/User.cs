using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsülleme.Models
{
    public class User
    {
        public User(string _userName, string _password)
        {
            userName = _userName;
            password = _password;
        }

        string _password;
        public string userName { get; set; }
        public string password {
            get 
            {
                return _password;
            }
            set 
            {
                if (value.Length < 4) {
                System.Windows.Forms.MessageBox.Show("en az 4 karakterli bir şifre belirleyin! ");
                Application.Restart();
                }
                _password = value;
            } 
        }
    }
}
