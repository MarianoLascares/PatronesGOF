using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strategy
{
    public class AntivirusAvanzado : AnalisisAvanzado
    {
        public override void Iniciar()
        {
            Console.WriteLine("Antivirus avanzado - Análisis avanzado iniciado");
        }
        public override void AnalizarKeyloggers()
        {
            try
            {
                Console.WriteLine("Analizando Keyloggers");
                Thread.Sleep(1000);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
        }

        public override void AnalizarMemoria()
        {
            try
            {
                Console.WriteLine("Analizando Memoria Ram");
                Thread.Sleep(1000);            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
        }

        public override void AnalizarRootkits()
        {
            try
            {
                Console.WriteLine("Analizando en busca de Rootkits");
                Thread.Sleep(1500);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
        }

        public override void DescomprimirZip()
        {
            try
            {
                Console.WriteLine("Analizando archivos .zip");
                Thread.Sleep(2000);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
        }

        public override void Detener()
        {
            Console.WriteLine("Antivirus avanzado - Análisis avanzado terminado");
        }

    }
}
