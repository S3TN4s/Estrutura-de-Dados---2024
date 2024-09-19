using System;

class Program
{
    private static int contador = 0; 
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Pressione 'g' para gerar uma nova senha ou 's' para sair.");
            char acao = Console.ReadKey(true).KeyChar;

            if (acao == 'g')
            {
                GerarSenha();
            }
            else if (acao == 's')
            {
                Console.WriteLine("Saindo do programa...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }

    static void GerarSenha()
    {
        senhas.Push(contador); // Adiciona a senha à pilha
        Console.WriteLine($"Senha gerada: {contador}");
        contador++; // Incrementa o contador para a próxima senha
    }
}

/*
using System;
using System.Collections.Generic;

class Program
{
    private static Stack<int> senhas = new Stack<int>();
    private static int contador = 1; // Inicia a contagem de senhas

    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Senhas para Atendimento no Caixa");
        
        while (true)
        {
            Console.WriteLine("\nDigite 'g' para gerar uma nova senha ou 's' para sair.");
            char acao = Console.ReadKey(true).KeyChar;

            if (acao == 'g')
            {
                GerarSenha();
            }
            else if (acao == 's')
            {
                Console.WriteLine("Saindo do programa...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }

    static void GerarSenha()
    {
        senhas.Push(contador); // Adiciona a senha à pilha
        Console.WriteLine($"Senha gerada: {contador}");
        contador++; // Incrementa o contador para a próxima senha
    }

    static void AtenderCliente()
    {
        if (senhas.Count > 0)
        {
            int senhaAtendida = senhas.Pop(); // Remove a senha do topo da pilha
            Console.WriteLine($"Atendendo cliente com a senha: {senhaAtendida}");
        }
        else
        {
            Console.WriteLine("Nenhuma senha disponível para atendimento.");
        }
    }
}