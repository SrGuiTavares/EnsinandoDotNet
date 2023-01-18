Console.WriteLine("Hello world \n \n");
PedirNumeros();

void PedirNumeros()
{
    Console.WriteLine("Digite o primeiro valor: ");
    var valor1 = Console.ReadLine();

    Console.WriteLine("Digite o segundo valor: ");
    var valor2 = Console.ReadLine();

    Console.WriteLine("Digite o valor correspondente a operação desejada: \n" +
    "1- Somar \n 2- Dividir \n 3- Multiplicar");
    var operacao = Console.ReadLine();

    ResolverConta(Convert.ToInt32(valor1), Convert.ToInt32(valor2), operacao);
}

int ResolverConta(int valor1, int valor2, string operacao)
{
    if (operacao == "1")
    {
        return valor1 + valor2;
    }

    else if (operacao == "2")
    {
        return valor1 / valor2;
    }

    else if (operacao == "3")
    {
        return valor1 * valor2;
    }

    else
    {
        Console.WriteLine("O valor da operação desejada não é válido, digite um numero entre 1 e 3");
        PedirNumeros();
        return 0;
    }
}






