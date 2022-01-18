using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUser
{
    internal class Utilisateur
    {
        private string login;
        private string password;

        public Utilisateur() { }

        public string Login
        {
            get { return login; } set { login = value; } 
        }
        public string Password
        { get; set; }
    }
}
