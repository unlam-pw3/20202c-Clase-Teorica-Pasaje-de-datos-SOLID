using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Apyn { get; set; }
        public int Incetivo { get; set; }
        

        public string Mostrar()
        {
            return $"nombre {Apyn}";
        }


        public void GrabarEmpleado()
        {
            //Log
        }

        public virtual int CalcularSalario()
        {
            return 15000;
        }

        //public int CalcularSalario(int tipo)
        //{
        //    //1 ADM
        //    //2 PRO
        //    //3 ANA
        //    int salario = 0;

        //    switch (tipo)
        //    {
        //        case 1:
        //            //Logica de administrativo
        //            salario = 160 * 100;
        //            break; 
        //        case 2:
        //            //Logica PROgramador
        //            salario = 30000;
        //            break;
        //        case 3:
        //            salario = 25000 + Incetivo;
        //            //Analista
        //            break;
        //        case 4:
        //            salario = 30000 + Incetivo;
        //            break;
        //        default:
        //            break;
        //    }
        //    return salario;

        //}


    }
}
