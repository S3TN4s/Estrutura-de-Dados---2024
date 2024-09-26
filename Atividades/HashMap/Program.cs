// Exemplo de uma agenda telefonica

using System.Collections;

Hashtable phonebook = new Hashtable()
{
    //{ "Key", "Value" },
        { "Thomazzi", "49-99961-0150" },
        { "Mauricio Gonzatto", "49-99975-8575" },  
        {"Gabriel Bianchi", "49-99105-8904" },

};

//É possivel adicionar elementos de diversas formas, pelo propio indice chave inexistente

phonebook["Thiago Padilha"] = "49-99176-8255";

// Ou pelo método Add()

phonebook.Add("Marcos", "49-99202-6169");

// Entretanto, a HashTable verifica se há duplicidade e chave e pode lançar uma exeption

try
{
    phonebook.Add("Mauricio Gonzatto", "419-99975-8575");
}   
catch (Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir, valor  repetido");
    Console.WriteLine(ex.Message);
    
}

// Percorrendo itens da HashTable
Console.WriteLine("Agenda telefonica: ");
if(phonebook.Count == 0)
    Console.WriteLine("A agenda está vazia");
else
    foreach(DictionaryEntry entry in phonebook)
        Console.WriteLine($"{entry.Key}:{entry.Value}");
    
