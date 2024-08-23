using System;

class Teste
{
    static void Main()
    {
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine();

        
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

       
        Console.WriteLine("Seu nome é " + nome + " e você tem " + idade + " anos, certo?");
        
       
        Console.Write(" Sim/Não ");
        string resposta = Console.ReadLine();
        
        
    
        bool confirmacao;
        
        if (resposta.ToLower() == "Sim" || resposta.ToLower() == "sim")
        {
            confirmacao = true; // O usuário disse "sim"
        }
        else
        {
            confirmacao = false; // O usuário disse "não"
        }

       
       
       
        // Exibir o resultado
        if (confirmacao)
        {
            Console.WriteLine("Ok, cadastro realizado com Sucesso!");
        }
        else
        {
            Console.WriteLine("Cadastro nao realizado!");
        }
    
        
        
    }
}
        
        
        
    