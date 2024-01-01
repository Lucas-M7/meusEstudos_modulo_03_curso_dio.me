using System.Globalization;
using System.Threading.Tasks.Dataflow;

string dataString = "2024-13-01 13:00";

bool sucesso = DateTime.TryParseExact(dataString,
                                "yyyy-MM-dd HH:mm",
                                CultureInfo.InvariantCulture,
                                DateTimeStyles.None,
                                out DateTime data);


if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else{
    Console.WriteLine($"{dataString} não é uma data válida");
}










// DateTime dataAtual = DateTime.Now; // Data e hora atual que está configurada no pc

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));