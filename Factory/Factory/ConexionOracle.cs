using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ConexionOracle : IConexion
    {
        private String host;
        private String port;
        private String username;
        private String password;

        public ConexionOracle()
        {
            this.host = "localhost";
            this.port = "1521";
            this.username = "admin";
            this.password = "123";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a Oracle");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó de Oracle");
        }
    }
}
