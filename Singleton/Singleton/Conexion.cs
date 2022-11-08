using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Conexion
    {
        //Declaración
        private static Conexion instancia;

        //Evita instancias con operador new
        private Conexion()
        {
        }

        //Se obtiene la instancia solo mediante este método
        public static Conexion getInstancia()
        {
            if(instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public void Conectar()
        {
            Console.WriteLine("Me conecté a la BD");
        }

        public void Desconectar()
        {
            Console.WriteLine("Me desconecté de la BD");
        }
    }
}
