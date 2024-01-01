using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades.Models
{
    public class Pessoa
    {
        //Construtor 1
        public Pessoa()
        {

        }

        //Construtor 2
        public Pessoa(string nome, string sobrenome, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
        }

        private string _nome; //Modificadores de acesso (private)
        private int _idade;
        private string _email;

        public string Nome //Propriedade
        {
            get => _nome.ToUpper(); //Get => Pega o valor e retorna algo

            set //Set => Validação de valor
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; } //Propriedade

        public string NomeCompleto => $"Nome: {Nome} {Sobrenome}\nEmail: {Email}\n".ToUpper(); //Propriedade só de leitura (get) usando uma body expression (=>)

        public string Email
        {
            get => _email; //Get => Pega o valor e retorna algo

            set //Set => Validação de valor
            {
                if (value == "")
                {
                    throw new ArgumentException("Email não pode ficar vazio");
                }
                _email = value;
            }
        }

        public int Idade //Propriedade
        {
            get => _idade; //Get => Pega o valor e retorna algo

            set //Set => Validação de valor
            {
                if (value < 0 || value == 0 || value < 18)
                {
                    throw new ArgumentException("Idade inválida");
                }
                _idade = value;
            }
        }

        public void Apresentar() //Método
        {
            Console.WriteLine($"Idade: {Idade}\nEmail: {Email}");
        }
    }
}