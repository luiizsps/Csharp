using System;

public class exe
{
    static void Main(string[] args)
    {
        Console.WriteLine("informe o valor do produto: ");
        float.TryParse(Console.ReadLine(), out float valor);

        valor = valor < 20.0? valor*1.45F : valor*1.30F;

        Console.WriteLine($"O valor da venda foi de {valor} reais");
    }
}
