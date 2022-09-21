//Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int acc = 0;
while (acc <= num)
{
    Console.Write($"{acc}, ");
    acc = acc + 2;
}