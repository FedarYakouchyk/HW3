Console.Write("Введите любое 5-ти значное число: ");
string? num = Console.ReadLine();
int size = Convert.ToInt32(Convert.ToString(num!.Length));
int i = Convert.ToInt32(Convert.ToString(num[0]));
if (size == 5)
{

    if (num[0] == num[4] && num[1] == num[3])
    {
        System.Console.WriteLine("Поздравляем, данное число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Данное число не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Повторите попытку, введённое вами число не является 5-ти значным.");
}
