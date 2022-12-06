Console.Write("Введите 1 число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} является больше числа {numberB}");
}
else
{
    Console.WriteLine($"Число {numberB} является больше числа {numberA}");
}