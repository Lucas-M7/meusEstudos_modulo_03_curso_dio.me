# Stack, Heap e Garbage Colletor no C#

## Introdução a Tipos de Memória

- Stack: É uma matriz de memória, é uma estrutura de dados LIFO (Last In First Out). E nele os dados podem ser adicionados e excluídos apenas da parte do superior dele.

- Heap: É uma área de memória onde blocos são alocados para armazenar certos tipos de objetos de dados. Nele, os dados podem ser adicionados e removidos em qualquer ordem.

## O Que Acontece no Stack e Heap?

No stack, "Coisas" declaradas com a seguinte lista de declarações de tipo são Tipos de Valores (porque eles são de System.ValueType): bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct, uint, ulong, ushort.

No heap, são Tipos de Referência: classe, interface, objeto, delegado, cadeia de caracteres.

Na stack, a alocação de memória é estática.
Na heap, a alocação de memória é dinâmica.

Quando instruções dos tipos de valores são executadas, por exemplo um "int a = 77;", ela é alocada na memória stack, enquanto na heap são alocados objetos e outros tipos já citados acima, por exemplo "MeuObjeto obj1 = new MeuObjeto()".
Esse objeto, quando executado será alocado uma referência na memória stack e terá um ponteiro internamente indicando para a heap, onde irá estar o real objeto.

## Garbage Collector

O coletor de lixo gerencia a alocação e liberação de memória para o seu aplicativo. Cada vez que um novo objeto for criado o CLR aloca memória para o objeto a partir da heap.