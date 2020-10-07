using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DIP
{
    //Inversión de Dependencias
    class EmpleadoService
    {
        //EmpleadoAccesoDatos empleadoDAO { get; set; }

        IEmpleadoAccesoDatos empleadoDAO { get; set; }

        //Inyección por Constructor
        public EmpleadoService(IEmpleadoAccesoDatos empleadoDAO)
        {
            this.empleadoDAO = empleadoDAO;        
        }

        public Empleado ObtenerPorId(int id)
        {
            return empleadoDAO.ObtenerPorId(id);        
        }
    }
}
