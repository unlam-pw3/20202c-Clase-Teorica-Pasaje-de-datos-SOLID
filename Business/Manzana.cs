using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Manzana : Fruta
    {

        public override string MostrarColor()
        {
            return "Rojo"; 
        }            
    }

    public class Naranja : Fruta
    {
        public override string MostrarColor()
        {
            return "Anaranjado";
        }
    }

    public abstract class Fruta
    {

        public abstract string MostrarColor();
      
    }

}
