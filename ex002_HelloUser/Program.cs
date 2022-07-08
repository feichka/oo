internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Напишите свое имя");
        string?username = Console.ReadLine();
        Console.WriteLine("Привет, ");
        Console.WriteLine(username);
    }
}