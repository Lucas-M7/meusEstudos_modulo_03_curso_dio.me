using System.Runtime.CompilerServices;

Dictionary<string, int> idades = new Dictionary<string, int>();

idades.Add("Lucas", 18);
idades.Add("Fábio", 18);
idades.Add("Kauã", 17);

idades["Lucas"] = 19;

foreach(var item in idades)
{
    Console.WriteLine($"Nome: {item.Key}\tIdade: {item.Value}");
}

















//////////// Pilhas

// Stack<int> pilha = new Stack<int>();

// pilha.Push(5);
// pilha.Push(4);
// pilha.Push(3);

// pilha.Peek();

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }



//////////// Filas

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(5);
// fila.Enqueue(4);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");