
bool continua = true;
do
{
    Console.WriteLine("\n" +
        "-----------------------------------------------------------\n" +
        "| Ola, bem vindo a calculadora, que operação deseja fazer?|\n" +
        "| 1 - somar                                               |\n" +
        "| 2 - subtair                                             |\n" +
        "| 3 - multiplicar                                         |\n" +
        "| 4 - dividir                                             |\n" +
        "| 5 - Sair                                                |\n" +
        "-----------------------------------------------------------");

        int opcao = Convert.ToInt16(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite os numeros que deseja somar, quando finaliza digite 'sair', tudo minusculo");
            double soma = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "sair")
                {
                    Console.Clear();
                    Console.WriteLine("O resultado da soma foi: " + soma + "\n");
                    break;
                }
                else
                {
                    double valor = Convert.ToDouble(input);
                    soma += valor;
                }
            }
            break;


        case 2:
            Console.WriteLine("Digite o numeo que quer subtrair");
            double numeroTotal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite os numeros para subtrair, quando finalizar digite 'sair', tudo minusculo");
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "sair")
                {
                    Console.Clear();
                    Console.WriteLine("O resultado da soma foi: " + numeroTotal);
                    break;
                }
                else
                {
                    double valor = Convert.ToDouble(input);
                    numeroTotal -= valor;
                }
            }
            break;

        case 3:
            Console.WriteLine("Digite os numeros que deseja multiplicar, quando finaliza digite 'sair', tudo minusculo");
            double mult = Convert.ToDouble(Console.ReadLine());
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "sair")
                {
                    Console.Clear();
                    Console.WriteLine("O resultado da multiplicacao foi: " + mult);
                    break;
                }
                else
                {
                    double valor = Convert.ToDouble(input);
                    mult *= valor;
                }
            }
            break;

        case 4:
            Console.WriteLine("Digite o numeo que quer dividir");
            numeroTotal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite os numeros para dividir, quando finalizar digite 'sair', tudo minusculo");
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "sair")
                {
                    Console.Clear();
                    Console.WriteLine("O resultado da divisao foi: " + numeroTotal);
                    break;
                }
                else
                {
                    double valor = Convert.ToDouble(input);
                    if (valor == 0.0)
                    {
                        Console.WriteLine("Impossivel dividir por 0, digite outro valor, mas tende ao infinito! ");
                    }
                    else
                    {
                        numeroTotal /= valor;
                    }

                }
            }
            break;

        case 5:
            continua = false;
            break;

        default:
            Console.Clear();
            Console.WriteLine("Digite um valor valido! ");
            break;
    }

} while(continua);