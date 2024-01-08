using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_especias.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] myArr = new T[capacidade];

        public void AdicionarElementoAoArray(T elemento)
        {
            if (contador + 1 < 11)
            {
                myArr[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return myArr[index]; }
            set { myArr[index] = value; }
        }

    }
}