try
{
    string[] linhas = File.ReadAllLines("Arquivos/pasta/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}catch(FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretório não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma execção genéria. {ex.Message}");
}
finally
{
    Console.WriteLine("Processo finalizado");
}