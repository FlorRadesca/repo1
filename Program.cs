using System;
using Classes;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rec = new Rectangulo(2, 4);
            Console.WriteLine ("El área del rectángulo es:" + rec.CalcularArea());

        Triangulo tri = new Triangulo (2, 4);
         Console.WriteLine ("El área del triángulo es:" + tri.CalcularArea());

        }
         

         


        }
    }

