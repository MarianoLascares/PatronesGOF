using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class AutoPrototype
    {
        protected String _color;
        protected String _modelo;

        public String Color { set => _color = value; }
        public String Modelo { set => _modelo = value; }

        public abstract AutoPrototype Clonar();
        public abstract string VerAuto();
    }
}
