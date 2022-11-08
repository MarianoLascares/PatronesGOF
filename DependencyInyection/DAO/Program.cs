using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConexion cx1 = new ConexionMySQL("aaaa", "231", "localhost");
            IConexion cx2 = new ConexionPostgre("bbbb", "321", "192.168.1.1");


            PersonaDAO dao = new PersonaDAOImpl();
            dao.setConexion(cx2);
            dao.GetAll();            

            Console.ReadLine();
        }
    }
}
