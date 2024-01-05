using System.ComponentModel.Design;
using System.Text;
using gerenciadorDePacotes.Models;
using Newtonsoft.Json;

Vendas v1 = new Vendas(7, "Pen-Drive", 27.00M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);
