using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DIP
{
    class EmpleadoAccesoDatos : IEmpleadoAccesoDatos
    {

        public Empleado ObtenerPorId(int id)
        {
            //traer el empleado 

            return new Empleado() { Apyn = "Juiz Joaquin", Id= id };

        }

    }
}
