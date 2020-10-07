using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Administrativo : Empleado
    {
        public override int CalcularSalario()
        {
            return 160 * 100;
        }

    }
}
