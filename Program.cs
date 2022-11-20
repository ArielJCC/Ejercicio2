//Crear un programa que lea un número e indique si es par o no 

internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Digite un número");
        num = int.Parse(Console.ReadLine());

        if(num %2 == 0)
        {
            Console.WriteLine("El número es Par");
        }
        else
        {
            Console.WriteLine("el número no es Par (Impar)");
        }
    }
}