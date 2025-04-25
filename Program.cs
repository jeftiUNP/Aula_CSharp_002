using System;

namespace JEFTI{

    class Pessoa{
        
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        public Pessoa(string Nome, int Idade){ //construtor
            this.Nome = Nome;
            this.Idade = Idade;
        }
        
        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }

        
    
    }

        class Program{
            public static void Main(string [] args){
                Pessoa lucas = new Pessoa("lucas", 25);
                // lucas.Nome = "lucas";
                // lucas.Idade = 25;

                Pessoa joao = new Pessoa("joao", 18);
                Console.WriteLine(lucas.Nome());
            }
        }


}