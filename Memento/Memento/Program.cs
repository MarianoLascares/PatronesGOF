using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombreJuego = "Crash Bandicoot";

            Juego juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(1);

            Caretaker caretaker = new Caretaker();
            Originator originator = new Originator();

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(2);
            originator.setEstado(juego);

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(3);
            originator.setEstado(juego);

            caretaker.addMemento(originator.guardar());

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(4);
            originator.setEstado(juego);

            caretaker.addMemento(originator.guardar());

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(5);
            originator.setEstado(juego);

            originator.restaurar(caretaker.GetMemento(1));

            juego = originator.getEstado();
            Console.WriteLine(juego.toString());
            Console.ReadKey();
        }
    }
}
