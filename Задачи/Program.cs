// ЗАДАЧА 2.
// Написать программу, которая на вход два числа и выдаёт,
// какое число больше, а какое меньше.
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

int max = a;

if (a > max) max = a;
if (b > max) max = b;

int min = b;

if (a < max) min = a;
if (b < max) min = b;

Console.WriteLine($"{max} больше чем {min}, max = {max}");

