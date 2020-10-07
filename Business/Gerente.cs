using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class Gerente : Empleado
    {

        public override int CalcularSalario()
        {
            return 35000 + Incetivo;
        }
    }
}
