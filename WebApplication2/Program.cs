using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Escolha uma opera��o:");
            Console.WriteLine("1. Adi��o");
            Console.WriteLine("2. Subtra��o");
            Console.WriteLine("3. Multiplica��o");
            Console.WriteLine("4. Divis�o");
            Console.WriteLine("5. Sair");

            Console.Write("Digite o n�mero da opera��o desejada: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    RealizarAdicao();
                    break;
                case "2":
                    RealizarSubtracao();
                    break;
                case "3":
                    RealizarMultiplicacao();
                    break;
                case "4":
                    RealizarDivisao();
                    break;
                case "5":
                    Console.WriteLine("Encerrando o programa...");
                    return;
                default:
                    Console.WriteLine("Op��o inv�lida. Por favor, escolha uma op��o v�lida.");
                    break;
            }
        }
    }

    static void RealizarAdicao()
    {
        Console.Write("Digite o primeiro n�mero: ");
        if (!double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("N�mero inv�lido.");
            return;
        }

        Console.Write("Digite o segundo n�mero: ");
        if (!double.TryParse(Console.ReadLine(), out double numero2))
        {
            Console.WriteLine("N�mero inv�lido.");
            return;
        }

        double resultado = numero1 + numero2;
        Console.WriteLine($"Resultado da adi��o: {resultado}");
    }

    static void RealizarSubtracao()
    {
        Console.Write("Digite o primeiro n�mero: ");
        if (!double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("N�mero inv�lido.");
            return;
        }

        Console.Write("Digite o segundo n�mero: ");
        if (!double.TryParse(Console.ReadLine(), out double numero2))
        {
            Console.WriteLine("N�mero inv�lido.");
            return;
        }

        double resultado = numero1 - numero2;
        Console.WriteLine($"Resultado da subtra��o: {resultado}");
    }

    static void RealizarMultiplicacao()
    {
        Console.Write("Digite o primeiro n�mero: ");
        if (!double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("N�mero inv�lido.");
            return;
        }

        Console.Write("Digite o segundo n�mero: ");
        if (!double.TryParse(Console.ReadLine(), out double numero2))
        {
            Console.WriteLine("N�mero inv�lido.");
            return;
        }

        double resultado = numero1 * numero2;
        Console.WriteLine($"Resultado da multiplica��o: {resultado}");
    }

    static void RealizarDivisao()
    {
        Console.Write("Digite o primeiro n�mero: ");
        if (!double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("N�mero inv�lido.");
            return;
        }

        Console.Write("Digite o segundo n�mero: ");
        if (!double.TryParse(Console.ReadLine(), out double numero2))
        {
            Console.WriteLine("N�mero inv�lido.");
            return;
        }

        if (numero2 != 0)
        {
            double resultado = numero1 / numero2;
            Console.WriteLine($"Resultado da divis�o: {resultado}");
        }
        else
        {
            Console.WriteLine("N�o � poss�vel dividir por zero.");
        }
    }
}
