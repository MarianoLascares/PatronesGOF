using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ConexionRESTCompras : IConexionREST
    {
        public void leerURL(string url)
        {
            Console.WriteLine("Conectándose a " + url);
        }
    }
}
