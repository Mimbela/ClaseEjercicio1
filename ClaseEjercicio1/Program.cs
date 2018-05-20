using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //características del objeto puerta
            Puerta puerta = new Puerta();
            puerta.Alto = 150;
            puerta.Ancho = 100;
            puerta.Color = 23;
            puerta.Abrir();
            puerta.MostrarEstado();

            Console.WriteLine("");

            Puerta puerta2 = new Puerta();
            puerta2.Alto = 90;
            puerta2.Ancho = 50;
            puerta2.Color = 45;
            puerta2.Abrir();
            puerta2.MostrarEstado();

            Console.WriteLine("");

            Porton porton = new Porton();
            porton.Color = 23;
            porton.Ancho = 150;
            porton.Alto = 230;
            porton.Bloqueado = true;
            porton.Bloquear();
            porton.MostrarEstado();


            Console.ReadKey();
        }
    }
}
