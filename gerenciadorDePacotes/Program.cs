﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Text;
using Newtonsoft.Json;
using gerenciadorDePacotes.Models;

string conteudoDoArquivo = File.ReadAllText("Arquivos/vendas.json"); //Leitura do arquivo

List<Venda> listaDaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoDoArquivo);

foreach (Venda venda in listaDaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
    $"Preço: {venda.Preco:c}, Data da Venta: {venda.DataVenda.ToString("dd/MM/yyy - HH:mm")} -" + 
    $" Desconto: {venda.Desconto:c}\n");
}































// DateTime dataAtual = DateTime.Now;

// List<Vendas> listaVendas = new List<Vendas>();

// Vendas v1 = new Vendas(id: 4, produto: "Pen-Drive", preco: 23.00M, dataAtual);
// Vendas v2 = new Vendas(id: 5, produto: "Sistema Operacional Kali", preco: 150.00M, dataAtual);
// Vendas v3 = new Vendas(id: 7, produto: "Spyware", preco: 200.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);
// listaVendas.Add(v3);

// string serializado1 = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado1);

// Console.WriteLine(serializado1);
