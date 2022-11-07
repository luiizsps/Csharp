using System;
class problems
{
  static void Main(string[] args) 
  {
    Console.WriteLine("Informe o n-esimo termo: ");
    int.TryParse(Console.ReadLine(), out int input);
    int valor1 = 0;
    int valor2 = 1;
    int aux;

    Console.Clear();

    for(int i = 0; i < input; i++) 
    {
      Console.WriteLine(valor2);
      aux = valor2;
      valor2 += valor1;
      valor1 = aux;
    }
