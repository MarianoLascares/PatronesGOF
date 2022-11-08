using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PersonaDAOImpl : PersonaDAO
    {
        private IConexion conexion;

        /*public PersonaDAOImpl(IConexion conexion)
        {
            this.conexion = conexion;
        }*/
        public void setConexion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Persona> GetAll()
        {
            this.conexion.Conectar();
            Console.WriteLine("Listando.....");
            return null;

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
