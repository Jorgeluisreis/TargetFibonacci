# TargetFibonacci

2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

### Minha abordagem

Esta solução usa instruções de **nível superior**, por isso a falta de namespaces, classes e método **main**.

A aplicação identifica se um número pertence ou não à uma sequência de Fibonacci.

* É pedido para inserir um número. Utilizando **int.TryParse** para garantir que a entrada seja um valor inteiro. Caso contrário, retorna um erro.
* O método **PertenceFibonacci** faz a verificação de fato, Inicia com 0 e 1 e vai gerando os próximos números da sequência até encontrar o número enviado pelo usuário ou ultrapassa-lo.
* A mesma pode retornar **false** se o número for false, se o número for negativo, pois na sequência não contém números negativos.
* É retornado se pertence ou não em **Console.WriteLine** se pertence ou não usando cálculo.