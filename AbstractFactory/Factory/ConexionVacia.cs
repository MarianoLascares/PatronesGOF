using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ConexionVacia : IConexion
    {
        public void conectar()
        {
            Console.WriteLine("NO SE ESPECIFICÓ PROVEEDOR");
        }

        public void desconectar()
        {
            Console.WriteLine("NO SE ESPECIFICÓ PROVEEDOR");
        }
    }
}
