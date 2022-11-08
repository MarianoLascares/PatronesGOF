using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PersonaDAOImpl : PersonaDAO
    {
        public List<Persona> GetAll()
        {
            List<Persona> list = new List<Persona>();
            Persona persona = new Persona();
            persona.Id = 1;
            persona.Nombres = "Mariano";
            list.Add(persona);

            persona = new Persona();
            persona.Id = 2;
            persona.Nombres = "Raul";
            list.Add(persona);

            return list;

        }

        public Persona leerPorId(int id)
        {
            return null;
        }

        public void Registrar(Persona persona)
        {
            Console.WriteLine($"Persona {persona.Nombres} registrada");
        }

        public void Actualizar(Persona persona)
        {
            Console.WriteLine($"Persona {persona.Nombres} actualizada");
        }

        public void Eliminar(int id)
        {
            Console.WriteLine($"id {id} eliminado");

        }
    }
}
