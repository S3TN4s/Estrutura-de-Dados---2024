using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Filas
{
    public class CallCenter
    {
        private int _Counter = 0;
        public Queue<Password>? Calls { get; set; }

        public CallCenter()
        {   
            Calls = new Queue<Password>();

        }
        
    public void Call(int clientId)
    {
        
        Calls!.Enqueue(
            new IncomingCall()

        {
             Id = ++_Counter,
             ClientId = clientId,
             CallTime = DateTime.Now
        }
        );
    }

     static void GerarSenha()
    {
        senhas.Push(contador); // Adiciona a senha à pilha
        Console.WriteLine($"Senha gerada: {contador}");
        contador++; // Incrementa o contador para a próxima senha
    }

    public void End(IncomingCall call) 
    {
        call.EndTime = DateTime.Now;

    }


    public bool AreWaitingCalls()
    {
        return (Calls!.Count > 0);
    }





    }   

}