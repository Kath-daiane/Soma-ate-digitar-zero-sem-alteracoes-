using System;

class Program
{
    static void Main()
    {
        int soma = 0;
        int numero;

        // Pedir ao usuário para digitar números até digitar 0
        while (true)
        {
            // Pedir ao usuário para digitar um número
            Console.Write("Digite um número (digite 0 para parar): ");
            numero = int.Parse(Console.ReadLine());

            // Se o número for 0, sai do loop
            if (numero == 0)
            {
                break;
            }

            // Adicionar o número à soma
            soma += numero;
        }

        // Exibir a soma total
        Console.WriteLine("A soma dos números digitados é: " + soma);
    }
}