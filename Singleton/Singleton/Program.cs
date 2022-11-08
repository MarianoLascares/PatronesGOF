using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conexion c = Conexion.getInstancia();
            c.Conectar();
            c.Desconectar();
            Console.ReadLine();
        }
    }
}
