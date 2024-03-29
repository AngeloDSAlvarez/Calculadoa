
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

    double numeroUm = 0;
    double numeroDois = 0;
    if (opcao != 5)
    {

        Console.WriteLine("Digite o primeio numero: ");
        numeroUm = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        numeroDois = Convert.ToDouble(Console.ReadLine());
    }



    switch (opcao)
    {
        case 1:
            Console.WriteLine(numeroUm + " + " + numeroDois + " = " + (numeroUm + numeroDois));
            break;


        case 2:
            Console.WriteLine(numeroUm + " - " + numeroDois + " = " + (numeroUm - numeroDois));
            break;

        case 3:
            Console.WriteLine(numeroUm + " x " + numeroDois + " = " + (numeroUm * numeroDois));
            break;

        case 4:
            Console.WriteLine(numeroUm + " / " + numeroDois + " = " + (numeroUm / numeroDois));
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