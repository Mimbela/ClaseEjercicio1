using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//HERENCIA
namespace ClaseEjercicio1
{
    public class Porton:Puerta
    {
        public bool Bloqueado { get; set; }

        public void Bloquear()
        {
            Bloqueado = true;
        }
        public void Desbloquear()
        {
            Bloqueado = false;
        }
        //Sobre escribimos el mostrado con el new
        public new void MostrarEstado()
        {
            Console.WriteLine("Ancho {0}", Ancho);
            Console.WriteLine("Alto {0}", Alto);
            Console.WriteLine("Color{0}", Color);
            Console.WriteLine("Abierta {0}", Abierta);
            Console.WriteLine("Bloqueado {0}", Bloqueado);
        }

    }
}
