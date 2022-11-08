using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class AlfaRomeoPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (AlfaRomeoPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Alfa Romeo {_modelo} color {_color}";
        }
    }
}
