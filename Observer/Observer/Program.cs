using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sujeto = new Subject();

            new SolObservador(sujeto);
            new PesoARGObservador(sujeto);
            new PesoMXObservador(sujeto);

            Console.WriteLine("Si desea cambiar 10 dolares obtendrá: ");
            sujeto.setEstado(10);
            Console.WriteLine("---------------------");
            Console.WriteLine("Si desea cambiar 100 dolares obtendrá: ");
            sujeto.setEstado(100);
            Console.ReadLine();
        }
    }
}
