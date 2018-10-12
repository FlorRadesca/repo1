using System;

namespace Classes{
    public class Rectangulo : Forma {
         public int Base {get; set;}
         public int Altura {get; set;}
         public Rectangulo (int Base, int Altura)
         {
             this.Base = Base;
             this.Altura = Altura;
         }
         public override float CalcularArea()
         {
             float AreaRectangulo = Base * Altura;
             return AreaRectangulo;
         }
    }
    

        
   
}