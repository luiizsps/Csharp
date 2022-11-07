using System;

public class exe
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int maior = 0;
        int menor = 0;

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o {i+1}º número inteiro: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        menor = numeros[0];
        maior = numeros[0];
        
        foreach(int numero in numeros)
        {
            if(numero > maior)
            {
                maior = numero;
            }
            else if(numero < menor)
            {
                menor = numero;
            }
        }

        Console.WriteLine($"O maior valor é {maior} e o menor é {menor}.");
    }
}
