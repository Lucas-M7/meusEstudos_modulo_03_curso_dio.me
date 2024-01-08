using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_especias.Models
{
    public static class ClassExtension
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}







/////////////////////////////// MÉTODO DE EXTENSÃO //////////////////