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




// ЗАДАЧА 4.
// Напиши программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int b1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int c1 = int.Parse(Console.ReadLine()!);

int max1 = a;

if (a1 > max1) max1 = a1;
if (b1 > max1) max1 = b1;
if (c1 > max1) max1 = c1;

Console.Write($"Максимальное число {max1}");




//Задача 6
// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if(n%2 !=0)
{
    Console.Write($"{n} Число нечётное");
}
else
{
    Console.Write($"{n} Число чётное");
}





//Задача 8
// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int a2 = 2;
while (a2 <= N)
{
    Console.Write($"{a2} ");
    a2 = a2 + 2;
}
 
while (a2%2 !=0)
{
   Console.Write($"{N} Четные числа "); 
}
    
