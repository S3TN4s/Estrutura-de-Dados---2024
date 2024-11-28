using System.Security.Cryptography.X509Certificates;

Dictionary<string, string> prateleiras = new(){
    { "1", "A1" },
    { "2", "A1" },
    { "3", "A1" },
    { "4", "A1" },
    { "5", "A1" },
    { "6", "A2" },
    { "7", "A8" },
    { "8", "C1" },
    { "9", "C2" },
    { "10", "B8" },
    { "11", "C8" },
    { "12", "A3" },
    { "13", "B5" },
    { "14", "B7" },
    { "15", "A5" },
    { "16", "B3" },
    { "17", "C5" },
    { "118", "C7" },
    { "19", "A6" },
    { "20", "A7" }
};

bool x = true;
while (x == true){
    Console.WriteLine("Digite o Código do produto para procurar ou (S) para sair");
    string? validador = Console.ReadLine();
    if (validador != null){
        if (validador.ToLower() == "s"){
            x = false;
        }else{
            if(prateleiras.ContainsKey(validador)){
                Console.WriteLine($"O produto está na prateleira {prateleiras[validador]}");
            }else{
                Console.WriteLine("Código Invalido! Tente novamente"); 
            }
        }
    }else{
        Console.WriteLine("Código Invalido! Tente novamente");  
    }
}
