using MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAO
{
    public interface PersonaDAO
    {
        List<Persona> Listar();
    }
}
