using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DIP
{
    interface IEmpleadoAccesoDatos
    {

        Empleado ObtenerPorId(int id);
        //...

    }
}
