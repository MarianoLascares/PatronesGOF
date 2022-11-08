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
            CRUD<Persona> dao = new PersonaDAOImpl();
            dao.GetAll().ForEach(x => Console.WriteLine(x.Nombres));
            
            Persona per = new Persona();
            per.Nombres = "Anibal";
            per.Id = 3;
            dao.Registrar(per);


            Console.ReadLine();
        }
    }
}
