using System;
using LocateCar.Model;

namespace LocateCar.View
{
    public class PessoaView
    {
        
        public static Pessoa MenuNovaPessoa()
        {
            Console.WriteLine("## Cadastrando nova pessoa ##");
            Console.Write("Digite seu nome: ");
            string? nome = Console.ReadLine();
            Console.Write("Digite seu CPF: ");
            string? cpf = Console.ReadLine();
            Console.Write("Digite seu Email: ");
            string? email = Console.ReadLine();

            return new Pessoa{ Name = nome, Cpf = cpf, Email = email };
        }

        
    }
}

