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
            FabricaAbstracta fabricaBD = FabricaProductor.getFactory("BD");
            IConexion cxBD1 = fabricaBD.getBD("MYSQL");
            cxBD1.conectar();

            FabricaAbstracta fabricaREST = FabricaProductor.getFactory("REST");
            IConexionREST cxRS1 = fabricaREST.getREST("COMPRAS");
            cxRS1.leerURL("https://www.youtube.com");

            Console.ReadLine();
        }
    }
}
