// Uma fila é a estrutura de dados que 
// Pode ser aplicada para representar
// a fila de atendimento da Cantina
// As pessoas que chegam entram no final da fila
// e as primeiras que chegaram sao as primeiras 
// a serem atendidas.


// A função ENQUEUE é responsavel por adicionar novos elementos a fila

//  A função DEQUEUE remove elementos da fila.

// Desta forma obedecem o principio do FIFO
// First in, first out
// Primeiro que entra é o primeiro a sair

using System.Data;
using Filas;

Random random = new Random();

CallCenter center = new();
center.Call(1234);
center.Call(5841);
center.Call(1478);
center.Call(3695);

while(center.AreWaitingCalls())
{
    Thread.Sleep(3000);

    IncomingCall call = center.Answer("Thiago");
    Console.WriteLine(
        @$"{DateTime.Now:HH:mm:ss}
             Chamado: #{call.Id} 
             De: {call.ClientId}
             Atendido por: {call.Consultant}"
    );
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(
        @$"Chamado: {call.Id}
            Encerrado às: {call.EndTime}"

    );
}