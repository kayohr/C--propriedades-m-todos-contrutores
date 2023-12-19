using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace intro_propriedades_métodos_contrutores.Models
{
    public class Pessoa
    {

         //Construtores
         public Pessoa()
        {

        }

         public Pessoa(string nome, string sobrenome)
        {
            Nome = nome; //Nome que equivale a propriedade Nome(public string Nome)
            Sobrenome = sobrenome; //O mesmo com SObrenome.
        }

        //----------------//

        private string _nome;
        private int _idade;
        

        public string Nome {
             get => _nome.ToUpper();
                    
             set
             {
                if (value == "")
                {
                    throw new ArgumentException("Nome invalido");
                }
                _nome = value;
             }

             }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade { 
            get => _idade;
            
            set
            {
                if (value < 0)
                {
                   throw new ArgumentException("Idade invalido");            
                }
                _idade = value;
            }
            }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}