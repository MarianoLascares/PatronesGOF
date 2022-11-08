using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConexionFabrica fabrica = new ConexionFabrica();

            IConexion cx1 = fabrica.getConexion("ORACLE");
            cx1.conectar();
            cx1.desconectar();

            IConexion cx2 = fabrica.getConexion("MYSQL");
            cx2.conectar();
            cx2.desconectar();

            IConexion cx3 = fabrica.getConexion("H2");
            cx3.conectar();
            cx3.desconectar();

            Console.ReadLine();
        }
    }
}
