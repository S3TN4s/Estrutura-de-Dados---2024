using Aula01;

// comentário de uma linha

/*
    comentário de 
    múltiplas linhas
*/

//int number; // Declarando variável
//number = 10;//Atribuindo valor

const int DAYS_IN_WEEK = 7; // Declarando constante

Console.WriteLine( $"A semana tem {DAYS_IN_WEEK}, dias"); //imprimindo String concatenada

// new tipo emumerador () ->  Invoca o metodo contrutor do objeto
// toda classe tem o seu construtor padrao impplicito sem argumntos/parametros
// é possivel sobreescrever este metodo especificando argumentos
// todavia, se fizermos, perdemos o original implicito e
// precisaremos defini-lo explicitamente

TipoEnumerador TypeEnun = new TipoEnumerador();

TipoEnumerador.Language enumEnglish = 
    TypeEnun.GetLanguageEnum("inglês");


Console.WriteLine($"o enum de English é {enumEnglish}");
