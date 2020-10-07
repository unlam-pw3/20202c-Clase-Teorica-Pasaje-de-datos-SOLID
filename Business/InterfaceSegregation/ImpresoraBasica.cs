using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.InterfaceSegregation
{
    interface ImpresoraBasica
    {
        string Imprimir(string texto );

        string Scanear(string texto);

    }
}
