using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");

            Console.Write("Digite o número da operação desejada: ");
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
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    static void RealizarAdicao()
    {
        Console.Write("Digite o primeiro número: ");
        if (!double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        Console.Write("Digite o segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double numero2))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        double resultado = numero1 + numero2;
        Console.WriteLine($"Resultado da adição: {resultado}");
    }

    static void RealizarSubtracao()
    {
        Console.Write("Digite o primeiro número: ");
        if (!double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        Console.Write("Digite o segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double numero2))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        double resultado = numero1 - numero2;
        Console.WriteLine($"Resultado da subtração: {resultado}");
    }

    static void RealizarMultiplicacao()
    {
        Console.Write("Digite o primeiro número: ");
        if (!double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        Console.Write("Digite o segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double numero2))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        double resultado = numero1 * numero2;
        Console.WriteLine($"Resultado da multiplicação: {resultado}");
    }

    static void RealizarDivisao()
    {
        Console.Write("Digite o primeiro número: ");
        if (!double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        Console.Write("Digite o segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double numero2))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        if (numero2 != 0)
        {
            double resultado = numero1 / numero2;
            Console.WriteLine($"Resultado da divisão: {resultado}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }
    }
}
