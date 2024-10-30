using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o numero para ser realizada a verificação se o mesmo pertence a sequencia Fibonacci:");
        int num = int.Parse(Console.ReadLine());

        if (pertenceFibo(num))
        {
            Console.WriteLine($"O número {num} pertence a sequência Fibonacci");
        }
        else
        {
            Console.WriteLine($"O número {num} não pertence a sequência Fibonacci");
        }
    }
    static bool pertenceFibo(int n)
    {
        if (n == 0 || n == 1) return true;

        int a = 0;
        int b = 1;
        int c = a + b;

        while (c <= n)
        {
            if (c == n) return true;
            a = b;
            b = c;
            c = a + b;
        }

        return false;
    }
}