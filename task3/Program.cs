Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        double rez = Math.Pow(i, 3);
        System.Console.WriteLine($"{i}^3={rez}");
    }
}
else
{
    System.Console.WriteLine("Введено некорректное число");
}