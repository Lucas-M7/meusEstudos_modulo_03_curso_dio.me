using tuplas_operadorTernario_e_desconstrucao_de_um_objeto.Models;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}



























//  (string nome, int idade, string sobrenome, decimal altura) = ("Lucas", 18, "Mateus", 1.77M);

//  Console.WriteLine($"Nome: {nome}");
//  Console.WriteLine($"Sobrenome: {sobrenome}");
//  Console.WriteLine($"Idade: {idade}");
//  Console.WriteLine($"Altura: {altura}");



//Outras Sintaxes
// ValueTuple<int, string, string, decimal> outraTupla = (1, "Lucas", "Mateus", 1.77M);

// var outroExemplo = Tuple.Create(18, "Lucas", "Mateus", 1.77M);