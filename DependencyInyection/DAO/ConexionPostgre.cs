using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ConexionPostgre : IConexion
    {
        private String usuario;
        private String clave;
        private String host;

        public ConexionPostgre(string usuario, string clave, string host)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.host = host;
        }

        public void Conectar()
        {
            Console.WriteLine("Conectando a Postgre");
        }
    }
}
