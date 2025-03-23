Console.Write("Digite um número para verificar ele pertence a uma sequência de Fibonacci: ");
if (int.TryParse(Console.ReadLine(), out int numero))
{
    if (PertenceFibonacci(numero))
        Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
    else
        Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine("Entrada inválida. Digite um número inteiro para validar..");
}

static bool PertenceFibonacci(int n)
{
    if (n < 0) return false;

    int a = 0, b = 1;
    while (a <= n)
    {
        if (a == n) return true;
        int temp = a;
        a = b;
        b = temp + b;
    }
    return false;
}
