using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ConexionMySQL : IConexion 
    {
        private String host;
        private String port;
        private String username;
        private String password;

        public ConexionMySQL()
        {
            this.host = "localhost";
            this.port = "3306";
            this.username = "root";
            this.password = "123";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a MySQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó de MySQL");
        }
    }
}
