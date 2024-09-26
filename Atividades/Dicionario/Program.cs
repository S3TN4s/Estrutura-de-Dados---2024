// DIferente  da HashTable, o Dictionary nos permite especificar o tipo de dado que será  utilizado nos pares 
// Key -> Value
// Isso nos fornece uma estrutura fortemente tipada

using Dicionario;

Dictionary<string, string>dictionary = new Dictionary<string, string>()
{

{"Key1", "Value1"},
{"Key2", "Value2"},


};

// Obter valor do Dictionary

string val = dictionary["Key1"];

try
{
    val = dictionary["Key3"];
}
catch (Exception ex)
{
    Console.WriteLine("Erro ao obter o valor da Key3");
    Console.WriteLine(ex.Message);
}

// Verificando se a chave existe antes de acessar para evitar erros e prejuizos de execução
if( dictionary.ContainsKey("Key2") )
{
    Console.WriteLine($"Key2: {dictionary["Key2"]}");

}

// Outra forma de obter valor e evitar erro

dictionary.TryGetValue("Key4", out string? valor);
if(valor is not null)
    Console.WriteLine($"Key4: {valor}");
    
// Podemos adicionar da mesma forma pela chave inexistente
dictionary["Key0"] = "valor 0" ; 

//Percorrer o Dictinary
foreach(KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}:{kvp.Value}");
}

Dictionary<int, Pessoa> dicPessoa = new Dictionary<int, Pessoa>();
dicPessoa.Add(1, new Pessoa(){
    Id = 1,
    BirthDate = new DateTime(1984, 7 ,5),
    Name = "Mauricio Gonzatto"
    }
);  

foreach( KeyValuePair<int, Pessoa> kvp in dicPessoa)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.BirthDate);
}
    //escreva um programa para auxiliar empregadores de uma loja a encontrar uma localização em que um produto deveria se encontrar