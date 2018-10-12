using System;
using System.Collections.Generic;

namespace Classes{
    public class Triangulo : Forma{
        public int Base {get; set;}
        public int Altura {get; set;}

        public Triangulo (int Base, int Altura)
         {
             this.Base = Base;
             this.Altura = Altura;
         }
        public override float CalcularArea()
        {
            float AreaTriangulo = Base * Altura /2;
            return AreaTriangulo;


        }
        
    }
}