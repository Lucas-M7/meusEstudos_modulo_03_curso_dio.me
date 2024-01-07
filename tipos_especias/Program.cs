using gerenciadorDePacotes.Models;
using Newtonsoft.Json;

string conteudoDoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaDeVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoDoArquivo);


var listaAnonimo = listaDeVenda.Select(x => new { x.Produto, x.Preco });

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}\tPreço: {venda.Preco:c}");
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