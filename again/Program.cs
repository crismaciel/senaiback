using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
            {
            Console.WriteLine("Nome completo:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Idade:");
            string idade = Console.ReadLine();
            
            Console.WriteLine("Genero:");
            string genero = Console.ReadLine();
            
            Console.WriteLine("Estado civil:");
            string estado = Console.ReadLine();
            
            Console.WriteLine("Local nascimento:");
            string local = Console.ReadLine();

            Console.WriteLine("RG:");
            string rg = Console.ReadLine();

            Console.WriteLine("CPF:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Endereco:");
            string endereco = Console.ReadLine();

            Console.WriteLine("Profissao:");
            string profissao = Console.ReadLine();

            string mostrar = "\nNome: "+nome+"\nIdade: "+idade+"\nGenero: "+genero+"\nEestado: "+estado+ "\nLocal: "+ local + "\nRG: "+rg + "\nCPF: "+cpf +"\nEndereco: "+endereco + "\nProfissao: "+profissao;        
            Console.WriteLine(mostrar);












   
            }
    }
}
