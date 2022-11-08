using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ConexionSQLServer : IConexion
    {
        private String host;
        private String port;
        private String username;
        private String password;

        public ConexionSQLServer()
        {
            this.host = "localhost";
            this.port = "1433";
            this.username = "server";
            this.password = "123";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a SQLServer");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó de SQLServer");
        }
    }
}
