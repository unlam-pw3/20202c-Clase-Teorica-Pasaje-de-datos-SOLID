using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PasajeDatosClase06Oct.Models
{
    public class EmpleadoClienteVM
    {

        public string ApynEmpleado { get; set; }
        public string RazonSocialCliente { get; set; }


        public EmpleadoClienteVM( string apyn, string razon )
        {
            ApynEmpleado = apyn;
            RazonSocialCliente = razon; 
        }
    }
}