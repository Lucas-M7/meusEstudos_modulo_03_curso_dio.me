using gerenciadorDePacotes.Models;
using Newtonsoft.Json;
using tipos_especias.Models;


MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoAoArray(30);

Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoAoArray("Teste");

Console.WriteLine(arrayString[0]);












































dynamic variavelDinamica = 7;
//Console.WriteLine($"Tipo da variável {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "Texto";
//Console.WriteLine($"Tipo da variável {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = true;
//Console.WriteLine($"Tipo da variável {variavelDinamica.GetType()}, Valor: {variavelDinamica}");










// Anônimo em Coleções
 string conteudoDoArquivo = File.ReadAllText("Arquivos/vendas.json");

 List<Venda> listaDeVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoDoArquivo);

 var listaAnonimo = listaDeVenda.Select(x => new { x.Produto, x.Preco });

 foreach (var venda in listaAnonimo)
 {
    // Console.WriteLine($"Produto: {venda.Produto}\tPreço: {venda.Preco:c}");
 }







// Tipo Anônimo

// var myAnonimo = new { Idade = 18, Nome = "Lucas" };

// Console.WriteLine(myAnonimo.Nome + " " + myAnonimo.Idade);


////////////////////////////////////////////


///// Tipo Nulo

// bool? desejaReceberEmails = null;

//     //Verifica se tem um valor   |  Verifica se o valor é verdadeiro
// if (desejaReceberEmails.HasValue && desejaReceberEmails.Value)
// {
//     Console.WriteLine("Vai receber");
// }
// else
// {
//     Console.WriteLine("O user não respondeu ou optou por não receber");
// }