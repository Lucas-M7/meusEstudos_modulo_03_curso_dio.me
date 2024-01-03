using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace utilizando_throw_e_introducao_a_filas.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            try
            {
                Metodo4();
            }catch(Exception)
            {
                Console.WriteLine("Exceção Tratada");
            }finally
            {
                Console.WriteLine("Processo Finalizado");
            }
        }
        public void Metodo4()
        {
            throw new Exception("Occoreu uma exceção");
        }
    }
}