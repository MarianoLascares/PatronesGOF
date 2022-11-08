using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class AnalisisAvanzado : IEstrategia
    {
        public void Analizar()
        {
            Iniciar();
            AnalizarMemoria();
            AnalizarKeyloggers();
            AnalizarRootkits();
            DescomprimirZip();
            Detener();
        }
        public abstract void Iniciar();
        public abstract void AnalizarMemoria();
        public abstract void AnalizarKeyloggers();
        public abstract void AnalizarRootkits();
        public abstract void DescomprimirZip();
        public abstract void Detener();
    }
}
