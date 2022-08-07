Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} = болшее, {num2} = меньшее");
}
else if (num2 > num1)
{
    Console.WriteLine($"{num2} = болшее, {num1} = меньшее");
}
