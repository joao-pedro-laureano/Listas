public static class Matriz
{
    public static void Exercicio1()
    {
        const int X = 4, Y = 4;
        int[,] numero = new int[X, Y];
        int i, j, cont = 0;
        Console.WriteLine("Digite 16 números");
        for (i = 0; i < X; i++)
            for (j = 0; j < Y; j++)
            {
                numero[i, j] = int.Parse(Console.ReadLine());
                if (numero[i, j] > 10)
                    cont++;
            }

        for (i = 0; i < X; i++)
        {
            Console.WriteLine();
            for (j = 0; j < Y; j++)
                Console.Write(" " + numero[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine("O total de numero maiores que 10 é: " + cont);
    }
    public static void Exercicio2()
    {
        const int X = 5, Y = 5;
        int[,] numero = new int[X, Y];
        int i, j;

        for (i = 0; i < X; i++)
            for (j = 0; j < Y; j++)
            {
                if (i == j)
                    numero[i, j] = 1;
                else numero[i, j] = 0;
            }
        for (i = 0; i < X; i++)
        {
            Console.WriteLine();
            for (j = 0; j < Y; j++)
                Console.Write(" " + numero[i, j]);
        }
    }
    public static void Exercicio3()
    {
        const int X = 4, Y = 4;
        int[,] numero = new int[X, Y];
        int i, j;

        for (i = 0; i < X; i++)
            for (j = 0; j < Y; j++)
            {
                numero[i, j] = i * j;
            }
        for (i = 0; i < X; i++)
        {
            Console.WriteLine();
            for (j = 0; j < Y; j++)
                Console.Write(" " + numero[i, j]);
        }
    }
    public static void Exercicio4() //revisar
    {
        const int X = 4, Y = 4;
        int[,] numero = new int[X, Y];
        int i, j, maior, maiorlinha = 0, maiorcoluna = 0;
        Console.WriteLine("Digite 16 números");
        numero[0, 0] = int.Parse(Console.ReadLine());
        maior = numero[0, 0];
        for (i = 1; i < X; i++)
            for (j = 1; j < Y; j++)
            {
                numero[i, j] = int.Parse(Console.ReadLine());
                if (numero[i, j] > maior)
                    maiorlinha = i;
                maiorcoluna = j;
            }

        for (i = 0; i < X; i++)
        {
            Console.WriteLine();
            for (j = 0; j < Y; j++)
                Console.Write(" " + numero[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine("A linha do maior é: " + maiorlinha + ". E a maior coluna é: " + maiorcoluna);
        Console.WriteLine();
        Console.WriteLine("O total de numero maiores que 10 é: ");
    }
    public static void Exercicio7()
    {
        const int X = 4, Y = 4;
        int[,] numero = new int[X, Y];
        int i, j;

        for (i = 0; i < X; i++)
            for (j = 0; j < Y; j++)
            {
                if (i < j)
                {
                    numero[i, j] = 2 * i + 7 * j - 2;
                }
                if (i == j)
                {
                    numero[i, j] = 3 * (i * i) - 1;
                }
                if (i > j)
                {
                    numero[i, j] = 4 * (i * i * i) - 5 * (j * j) + 1;
                }
            }
        for (i = 0; i < X; i++)
        {
            Console.WriteLine();
            for (j = 0; j < Y; j++)
                Console.Write(" " + numero[i, j]);
        }
    }
    public static void Exercicio8() //revisar
    {
        const int X = 3, Y = 3;
        int[,] numero = new int[X, Y];
        int i, j, cont = 0;
        Console.WriteLine("Digite 9 números");
        for (i = 0; i < X; i++)
            for (j = 0; j < Y; j++)
            {
                numero[i, j] = int.Parse(Console.ReadLine());
                if (i != j )
                    cont++;
            }

        for (i = 0; i < X; i++)
        {
            Console.WriteLine();
            for (j = 0; j < Y; j++)
                Console.Write(" " + numero[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine("O total de numero maiores que 10 é: " + cont);
    }
    public static void Exercicio10()
    {
        const int X = 3, Y = 3;
        int[,] numero = new int[X, Y];
        int i, j, soma = 0;
        Console.WriteLine("Digite 9 números");
        for (i = 0; i < X; i++)
            for (j = 0; j < Y; j++)
            {
                numero[i, j] = int.Parse(Console.ReadLine());
                if (i == j)
                    soma = soma + numero[i, j];
            }

        for (i = 0; i < X; i++)
        {
            Console.WriteLine();
            for (j = 0; j < Y; j++)
                Console.Write(" " + numero[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine("A soma dos números da diagonal principal é: " + soma);
    }
}