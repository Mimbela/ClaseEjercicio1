using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Puerta
    {
        public int Ancho { get; set; }//anchura de la puerta
        public int Alto { get; set; }//alto de la puerta
        public int Color { get; set; }// color de la puerta

        public bool Abierta { get; set; }//abierta o cerrada

        public  void Abrir ()
        {
            Abierta = true;
        }

        public void Cerrar()
        {
            Abierta = false;
        }

        public void MostrarEstado()
        {
            Console.WriteLine("Ancho {0}",Ancho);
            Console.WriteLine("Alto {0}", Alto);
            Console.WriteLine("Color{0}",Color);
            Console.WriteLine("Abierta {0}",Abierta);
        }

        //creamos un constructor de la clase Puerta
        public Puerta()
        {
            Ancho = 100;
            Alto = 200;
            Color = 30;
            Abierta = false;

        }
        //como hay dos constructores a esto se le llama sobrecarga
        public Puerta (int a, int al)
        {
            Ancho = a;
            Alto = al;
        }
        
    }
}
