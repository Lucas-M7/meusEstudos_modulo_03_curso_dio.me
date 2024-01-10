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
Enquanto o espaço de endereço estiver disponível no heap, o tempo de execução irá continuar a alocar espaço para novos objetos.
Eventualmente, o coletor de lixo deve realizar uma coleta a fim de liberar alguma memória.

## Benefícios do Coletor de Lixo

 - Livra os devs de ter que liberar memória manualmente.

 - Aloca os objetos no heap de forma eficiente.

 - Recupera objetos que não estão mais sendo usados, limpa sua memória e mantém a memória disponível para alocações futuras.

## Funcionamento do GC:

1 - Alocação de Memória:
    Quando um novo objeto em C# é criado, o GC aloca espaço para esse objeto na memória.

2 - Acompanhamento de Referência:
    O GC mantém um rastreamento das referências para cada objeto na memória.

3 - Identificação de Objetos Inalcançáveis:
    Periodicamente, o Garbage Collector verifica todos os objetos na memória e identifica aqueles que não têm mais referências a eles. Esses objetos são considerados inalcançáveis e candidatos à coleta de lixo.

4 - Geração de Objetos:
    O Garbage Collector classifica objetos em diferentes gerações (0, 1 e 2), com base em quanto tempo eles têm existido. A maioria dos objetos começa na Geração 0 e, se sobreviverem a algumas coletas de lixo, são promovidos para gerações mais altas.

5 - Coleta de Lixo:
    Quando ocorre uma coleta de lixo, o Garbage Collector remove os objetos inalcançáveis, liberando a memória ocupada por eles. A coleta de lixo é um processo assíncrono e é desencadeada automaticamente pelo sistema conforme necessário.

6 - Desempenho e Otimizações:
O Garbage Collector é projetado para otimizar o desempenho, minimizando o impacto nas operações do programa. Ele é altamente ajustado para ser eficiente e tenta realizar a coleta de lixo de maneira a causar o mínimo de 
interrupção possível no aplicativo.

7 - Gerenciamento de Recursos não Gerenciados:
    Embora o Garbage Collector seja eficaz no gerenciamento automático da memória para objetos gerenciados, é importante lembrar que ele não gerencia recursos não gerenciados, como arquivos, conexões de rede, etc. Nestes casos, é necessário implementar a interface IDisposable e usar o padrão using para garantir a liberação adequada desses recursos.