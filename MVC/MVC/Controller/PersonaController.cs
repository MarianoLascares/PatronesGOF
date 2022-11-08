using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.DAO;
using MVC.Model;

namespace MVC.Controller
{
    public class PersonaController
    {
        private List<Persona> lista;
        private PersonaDAOImpl dao;

        internal PersonaDAOImpl Dao { get => dao; set => dao = value; }

        public PersonaController()
        {
            lista = new List<Persona>();
            dao = new PersonaDAOImpl();
            this.Listar();
        }

        public void Listar()
        {
            lista = dao.Listar();
        }

        public List<Persona> getLista()
        {
            return lista;
        }
        public void setLista(List<Persona> lista)
        {
            this.lista = lista;
        }


    }
}
