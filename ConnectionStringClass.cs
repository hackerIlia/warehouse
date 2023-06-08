using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abracadabra
{
    public class ConnectionStringClass
    {
        public string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=warehouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public string ConnectionStringUsers = @"Data Source=.\SQLEXPRESS;Initial Catalog=users;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public int cod_email=1;
        public string login_forgot_password;
    }
}
