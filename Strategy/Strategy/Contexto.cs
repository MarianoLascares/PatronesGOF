using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Contexto
    {
        private IEstrategia estrategia;
        public Contexto(IEstrategia estrategia)
        {
            this.estrategia = estrategia;
        }
        public void Ejecutar()
        {
            this.estrategia.Analizar();
        }
    }
}
