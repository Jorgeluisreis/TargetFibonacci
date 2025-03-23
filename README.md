# TargetFibonacci

2) Dado a sequ�ncia de Fibonacci, onde se inicia por 0 e 1 e o pr�ximo valor sempre ser� a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um n�mero, ele calcule a sequ�ncia de Fibonacci e retorne uma mensagem avisando se o n�mero informado pertence ou n�o a sequ�ncia.

### Minha abordagem

Esta solu��o usa instru��es de **n�vel superior**, por isso a falta de namespaces, classes e m�todo **main**.

A aplica��o identifica se um n�mero pertence ou n�o � uma sequ�ncia de Fibonacci.

* � pedido para inserir um n�mero. Utilizando **int.TryParse** para garantir que a entrada seja um valor inteiro. Caso contr�rio, retorna um erro.
* O m�todo **PertenceFibonacci** faz a verifica��o de fato, Inicia com 0 e 1 e vai gerando os pr�ximos n�meros da sequ�ncia at� encontrar o n�mero enviado pelo usu�rio ou ultrapassa-lo.
* A mesma pode retornar **false** se o n�mero for false, se o n�mero for negativo, pois na sequ�ncia n�o cont�m n�meros negativos.
* � retornado se pertence ou n�o em **Console.WriteLine** se pertence ou n�o usando c�lculo.