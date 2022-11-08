using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ConexionPostgreSQL : IConexion
    {
        private String host;
        private String port;
        private String username;
        private String password;

        public ConexionPostgreSQL()
        {
            this.host = "localhost";
            this.port = "5433";
            this.username = "postgres";
            this.password = "123";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a PostgreSQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó de PostgreSQL");
        }
    }
}
