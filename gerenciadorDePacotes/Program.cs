using System.ComponentModel.Design;
using System.Text;
using gerenciadorDePacotes.Models;
using Newtonsoft.Json;

List<Vendas> listaVendas = new List<Vendas>();

Vendas v1 = new Vendas(id: 4, produto: "Pen-Drive", preco: 23.00M);
Vendas v2 = new Vendas(id: 5, produto: "Sistema Operacional Kali", preco: 150.00M);
Vendas v3 = new Vendas(id: 7, produto: "Spyware", preco: 200.00M);

listaVendas.Add(v1);
listaVendas.Add(v2);
listaVendas.Add(v3);

string serializado1 = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado1);

Console.WriteLine(serializado1);
