using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine("____________________________________________________________");
        
        Console.WriteLine("Você digitou: " + nome);
        
        Console.WriteLine("____________________________________________________________");

        
        Console.Write("Está correto? (s/n): ");
        string resposta1 = Console.ReadLine().ToLower();
        
        Console.WriteLine("____________________________________________________________");

        string nomec = nome; 
        if (resposta1 == "s")
        {
            Console.WriteLine("Registrado!");
        }
        else
        {
           
            Console.Write("Digite o nome correto: ");
            nomec = Console.ReadLine(); 
        }
        
        Console.WriteLine("                             ");
        
        
        Console.WriteLine("Nome Atualizado: " + nomec);
        
        Console.WriteLine("____________________________________________________________");

        // Solicita a idade do usuário
        Console.Write("Digite sua idade: ");
        int idade;
        while (!int.TryParse(Console.ReadLine(), out idade))
        {
            Console.Write("Idade inválida. Digite novamente: ");
        }
        Console.WriteLine("  ");
        // Exibe as informações

        Console.WriteLine("Seu nome é " + nomec + " e você tem " + idade + " anos, certo?");

        Console.WriteLine("____________________________________________________________");
        
        Console.WriteLine("                                                            ");

        // Pergunta se as informações estão corretas
        Console.Write("Sim/Não: ");
        string resposta = Console.ReadLine().ToLower();

        bool confirmacao;

        if (resposta == "sim")
        {
            confirmacao = true; // O usuário disse "sim"
        }
        else
        {
            confirmacao = false; // O usuário disse "não"
        }

        // Exibe o resultado
        if (confirmacao)
        {
            Console.WriteLine("                                   ");
            Console.WriteLine("Ok, cadastro realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("                                   ");
            Console.WriteLine("Cadastro não realizado!");
        }
    }
}
