using System;
class hello
{
  static void Main(string[] args) 
  {
    Console.WriteLine("Título: ");
    string title = Console.ReadLine();

    Console.WriteLine("Subtítulo: ");
    string subtitle = Console.ReadLine();

    Console.WriteLine("Autor: ");
    string author = Console.ReadLine();

    Console.WriteLine("Editora: ");
    string publisher = Console.ReadLine();

    Console.WriteLine("Número de páginas: ");
    bool success_page = int.TryParse(Console.ReadLine(), out int pgnumber);

    Console.WriteLine("Idioma: ");
    string lang = Console.ReadLine();

    Console.WriteLine("Data de publicação (dd/mm/yy): ");
    bool success_date = DateTime.TryParse(Console.ReadLine(), out DateTime date);
    
    Console.Clear();

    Console.WriteLine("Livro cadastrado com sucesso!");
    Console.WriteLine($"Livro: {title} - {subtitle}");
    Console.WriteLine($"Autor: {author}");
    Console.WriteLine($"Editora: {publisher}");
    Console.WriteLine($"Detalhes: Publicado em {date.ToString("MM/dd/yyyy")} com {pgnumber} páginas em {lang}");
    
    /*
    Console.WriteLine("Olá!");
    Console.WriteLine(name);

    DateTime datahj = new DateTime();
    Console.WriteLine(datahj);

    DateTime datetoday = DateTime.Now;
    Console.WriteLine(datetoday);
    Console.WriteLine(datetoday.DayOfYear);
    */
    }
}
