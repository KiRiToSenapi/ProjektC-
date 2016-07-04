using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Blutbank
{
    class Login
    {
        int id;
        String nutzername;
        String password;
        String befugniss;

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Nutzername
        {
            get
            {
                return nutzername;
            }

            set
            {
                nutzername = value;
            }
        }

        public string Befugniss
        {
            get
            {
                return befugniss;
            }

            set
            {
                befugniss = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
