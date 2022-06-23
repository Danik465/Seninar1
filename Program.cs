//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

internal class Program
{
    private static void Main(string[] args)
    {
        int numberA = Convert.ToInt32(Console.ReadLine());
        int numberB = Convert.ToInt32(Console.ReadLine());

        if (numberA == numberB*numberB)
        {
            Console.WriteLine($" число {numberA} является квадратом {numberB}");

        }
        else
        {
            Console.WriteLine($" число {numberA} не является квадратом {numberB}");


        }
    }
}