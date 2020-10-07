using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.InterfaceSegregation
{
    class LazerJectModelo2018 : ImpresoraBasica, IFAX
    {
        public string FAX(string texto)
        {
            //texto
            return "texto mensaje Fax";
        }

        public string Imprimir(string texto)
        {
            return "texto formateado";
        }

        public string Scanear(string texto)
        {
            return "Copio Scaneada";
        }
    }
}
