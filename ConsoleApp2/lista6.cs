
public static class lista6
{
    public static void Exercicio1()
    {
        int[] A = new int[7];

        A[1] = 1;
        A[2] = 0;
        A[3] = 5;
        A[4] = -2;
        A[5] = -5;
        A[6] = 7;

        Console.WriteLine("A soma dos itens 0, 1 e 5 é: " + A[0] + A[1] + A[5] + "\n");

        A[4] = 100;

        Console.WriteLine(A[0]);
        Console.WriteLine(A[1]);
        Console.WriteLine(A[2]);
        Console.WriteLine(A[3]);
        Console.WriteLine(A[4]);
        Console.WriteLine(A[5]);
        Console.WriteLine(A[6]);
    }
    public static void Exercicio2()
    {
        int[] A = new int[7];
        Console.WriteLine("Escreva 6 números");


        for (int i = 0; i <= 5; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("");
        Console.WriteLine(A[0]);
        Console.WriteLine(A[1]);
        Console.WriteLine(A[2]);
        Console.WriteLine(A[3]);
        Console.WriteLine(A[4]);
        Console.WriteLine(A[5]);
    }
    public static void Exercicio3()
    {
        double[] A = new double[10];
        double[] B = new double[10];
        Console.WriteLine("Escreva 10 números");

        for (int i = 0; i < 10; i++)
        {
            A[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            B[i] = A[i] * A[i];
            Console.WriteLine("A multiplicação do intem " + i + " vezes ele mesmo é " + B[i]);
        }
    }
    public static void Exercicio4()
    {
        int[] A = new int[9];
        int X, Y, b;
        Console.WriteLine("Escreva 8 números");

        for (int i = 1; i <= 8; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite o primeiro valor que deseja somar");
        Y = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor que deseja somar");

        X = int.Parse(Console.ReadLine());
        b = A[X] + A[Y];
        Console.WriteLine(b);
    }
    public static void Exercicio5()
    {
        int[] A = new int[11];
        int X, Y, b = 0;
        Console.WriteLine("Escreva 10 números");

        for (int i = 1; i <= 10; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
            if (A[i] % 2 == 0)
            {
                b++;
            }
        }
        Console.WriteLine("Tem " + b + " números pares");
    }
    public static void Exercicio6() // Deu merda !!
    {
        int[] A = new int[10];
        int maior, menor, Y, b;
        Console.WriteLine("Escreva 10 números");

        menor = int.Parse(Console.ReadLine());
        maior = menor;


        for (int i = 1; i < 10; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
            if (A[i] > maior)
            {
                A[i] = maior;
            }
            if (A[i] < menor)
            {
                A[i] = menor;
            }
        }
        Console.WriteLine("O maior é: " + maior + ". E o menor é: " + menor);
    }
    public static void Exercicio7()
    {
        Console.WriteLine("Escreva 10 números");
        int[] A = new int[10];
        int maior = 0;
        for (int i = 1; i < 10; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
            if (A[i] > maior)
            {
                maior = i;
            }
        }
        Console.WriteLine("O maior é: " + maior);
    }
}

