using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.InterfaceSegregation
{
    class HPBasica : ImpresoraBasica
    {
        //public string FAX(string texto)
        //{
        //    throw new NotImplementedException();
        //}

        public string Imprimir(string texto)
        {
            //logica para imprimir
            return "Texto Impreso";
        }

        public string Scanear(string texto)
        {
            return "copia escaneada";
        }
    }
}
