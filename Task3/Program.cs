Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());


if (n % 2 == 0)
{
    Console.WriteLine($"Число {n} является четным");
}
else
{
    Console.WriteLine($"Число {n} не является четным");
}