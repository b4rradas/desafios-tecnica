class Program
{
    static void Main()
    {
        Console.WriteLine("Informe a string para verificação da existência da letra a:");
        string frase = Console.ReadLine();

        int cont = 0;

        foreach (char c in frase)
        {
            if (c == 'a' || c == 'A')
            {
                cont++;
            }
        }

        if (cont > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {cont} vezes na string");
        }
        else
        {
            Console.WriteLine("A letra 'a' não aparece nenhuma vez na string");
        }
    }
}