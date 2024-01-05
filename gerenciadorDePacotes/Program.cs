using System.ComponentModel.Design;
using System.Text;
using gerenciadorDePacotes.Models;
using Newtonsoft.Json;

Vendas v1 = new Vendas(id: 4, produto: "Pen-Drive", preco: 23.00M);


string serializado1 = JsonConvert.SerializeObject(v1, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado1);

Console.WriteLine(serializado1);
