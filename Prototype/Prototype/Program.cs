using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoPrototype prototipoFiat = new FiatPrototype();
            AutoPrototype prototipoDS = new DSPrototype();
            AutoPrototype prototipoAR = new AlfaRomeoPrototype();

            AutoPrototype fiatPalio = prototipoFiat.Clonar();
            fiatPalio.Modelo = "Palio Fire";
            fiatPalio.Color = "Negro";
            Console.WriteLine(fiatPalio.VerAuto());

            AutoPrototype fiatUno = prototipoFiat.Clonar();
            fiatUno.Modelo = "Uno SRC";
            fiatUno.Color = "Blanco";
            Console.WriteLine(fiatUno.VerAuto());

            AutoPrototype ds3 = prototipoDS.Clonar();
            ds3.Modelo = "P3 Chic";
            ds3.Color = "Blanco";
            Console.WriteLine(ds3.VerAuto());

            AutoPrototype ds4 = prototipoDS.Clonar();
            ds4.Modelo = "4 Sport";
            ds4.Color = "Negro";
            Console.WriteLine(ds4.VerAuto());

            AutoPrototype ar145 = prototipoAR.Clonar();
            ar145.Modelo = "145";
            ar145.Color = "Negro";
            Console.WriteLine(ar145.VerAuto());

            AutoPrototype ar146 = prototipoAR.Clonar();
            ar146.Modelo = "146";
            ar146.Color = "Blanco";
            Console.WriteLine(ar146.VerAuto());


            Console.ReadKey();
        }
    }
}
