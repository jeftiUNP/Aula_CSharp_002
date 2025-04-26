namespace JEFTI.Models;

class Pessoa{
    
    public string Nome { get; set; }
    public int Idade { get; set; }
    
    // public Pessoa(string Nome, int Idade){ 
    //     this.Nome = Nome;
    //     this.Idade = Idade;
    // }
    
    public void Apresentar(){
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }

}
