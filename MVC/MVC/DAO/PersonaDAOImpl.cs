using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Model;

namespace MVC.DAO
{
    internal class PersonaDAOImpl : PersonaDAO
    {
        public List<Persona> Listar()
        {
            List<Persona> lista = new List<Persona>();
            Persona per = new Persona();
            per.Id = 1;
            per.Nombre = "Mariano";
            per.Edad = 29;
            lista.Add(per);

            per = new Persona();
            per.Id = 2;
            per.Nombre = "Ornela";
            per.Edad = 30;
            lista.Add(per);

            return lista;
        }
    }
}
