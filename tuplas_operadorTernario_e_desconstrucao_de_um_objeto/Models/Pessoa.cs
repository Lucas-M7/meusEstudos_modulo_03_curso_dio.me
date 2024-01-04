using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace tuplas_operadorTernario_e_desconstrucao_de_um_objeto.Models
{
    public class Pessoa
    {
        public string Nome { get; }
        public string Sobrenome { get; }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Lucas", "Mateus");
            var (nome, sobrenome) = pessoa;

            Console.WriteLine(nome + " " + sobrenome);
        }
    }
}