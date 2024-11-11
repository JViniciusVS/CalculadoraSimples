using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Simples em C#");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                Console.Write("Opção: ");
                string? opcao = Console.ReadLine();

                // Verifique se 'opcao' é nula
                if (string.IsNullOrEmpty(opcao))
                {
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }

                if (opcao == "5")
                {
                    Console.WriteLine("Encerrando a calculadora...");
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                if (!double.TryParse(Console.ReadLine(), out double numero1))
                {
                    Console.WriteLine("Entrada inválida. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Digite o segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double numero2))
                {
                    Console.WriteLine("Entrada inválida. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }

                double resultado = 0;
                bool operacaoValida = true;

                switch (opcao)
                {
                    case "1":
                        resultado = numero1 + numero2;
                        Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultado}");
                        break;
                    case "2":
                        resultado = numero1 - numero2;
                        Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultado}");
                        break;
                    case "3":
                        resultado = numero1 * numero2;
                        Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultado}");
                        break;
                    case "4":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                            operacaoValida = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        operacaoValida = false;
                        break;
                }

                if (operacaoValida)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
