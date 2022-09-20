public static class lista4
{
    public static void Exercicio1()
    {
        Double preco, soma = 0, uni = 0, compra = 0;

        do
        {
            Console.WriteLine("Digite o valor do produto para soma.");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto");
            uni = double.Parse(Console.ReadLine());
            compra = preco * uni;
            soma = soma + compra;
            if (uni >= 6)
            {
                soma = soma - soma * 10 / 100;
                Console.Write("Você recebeu o desconto de 10% nesse produto.");
            }
        } while (preco != 0);

        if (soma >= 300)
        {
            soma = soma - (soma * 25 / 100);
            Console.Write("Você recebeu o desconto de 25% no total de sua compra. O total foi de: R$" + soma);
        }

        else Console.WriteLine(soma);
    }
    public static void Exercicio2()
    {
        Console.WriteLine("Digite as notas");
        int a = 0, i = 0, nota = 0, maior = 0, menor = 0;

        do
        {
            a = int.Parse(Console.ReadLine());
            if (a > maior)
            {
                maior = a;
            }
            if (a > menor && a != 0)
            {
                menor = a;
            }
            nota = nota + a;
            i++;
        } while (a != 0);
        Console.WriteLine(menor);
        Console.WriteLine(maior);
        Console.WriteLine(nota / i);
    }
    public static void Exercicio3()
    {
        int peso, idade, a = 0, b = 0, c = 0, d = 0, e = 0;
        string sexo;
        double altura;
        do
        {
            Console.WriteLine("Digite seu sexo:");
            sexo = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso:");
            peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            altura = double.Parse(Console.ReadLine());

            if (sexo == "homem")
            {
                a++;
            }
            if (sexo == "mulher")
            {
                b++;
            }
            if (sexo == "mulher" && idade >= 30)
            {
                c++;
            }
            if (idade >= 24 && idade <= 35)
            {
                d++;
            }
            if (altura >= 1.84 || peso >= 100)
            {
                e++;
            }

        } while (idade != 0);
        Console.WriteLine("São " + a + " homens.");
        Console.WriteLine("São " + b + " mulheres.");
        Console.WriteLine("São " + c + " mulheres com mais de 30 anos.");
        Console.WriteLine("São " + d + " pessoas com a idade entre 25 e 34 anos.");
        Console.WriteLine("São " + e + " pessoas com peso acima de 100 quilos ou altura maior que 1,84.");
    }
    public static void Exercicio4()
    {
        int idade, a = 0, b = 0, c = 0, d = 0, e = 0;
        do
        {
            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 15 && idade != 0)
            {
                a++;
            }
            if (idade > 15 && idade <= 30)
            {
                b++;
            }
            if (idade > 30 && idade <= 45)
            {
                c++;
            }
            if (idade > 45 && idade <= 60)
            {
                d++;
            }
            if (idade > 60)
            {
                e++;
            }

        } while (idade != 0);
        Console.WriteLine("São " + a + " pessoas com até 15 anos.");
        Console.WriteLine("São " + b + " pessoas com idade entre 16 e 30 anos.");
        Console.WriteLine("São " + c + " pessoas com idade entre 31 e 45 anos.");
        Console.WriteLine("São " + d + " pessoas com a idade entre 46 e 60 anos.");
        Console.WriteLine("São " + e + " pessoas com mais de 60 anos.");
    }
    public static void Exercicio5()
    {
        int a = 0, b = 0, c = 0, maior = 0, menor = 0, meio = 0;

        Console.WriteLine("Digite 3 valores");
        a = int.Parse(Console.ReadLine());
        maior = a;
        menor = a;

        b = int.Parse(Console.ReadLine());

        if (b > maior) maior = b;
        if (b < menor) menor = b;

        c = int.Parse(Console.ReadLine());
        if (c > maior) maior = c;
        if (c < menor) menor = c;
        if (a != maior && a != menor) meio = a;
        if (b != maior && b != menor) meio = b;
        if (c != maior && c != menor) meio = c;

        Console.WriteLine(a + " " + b + " " + c + "\n");
        Console.WriteLine("Ordem crescente: " + menor + " " + meio + " " + maior + "\n");
        Console.WriteLine("Ordem decrescente: " + maior + " " + meio + " " + menor);
    }
}
