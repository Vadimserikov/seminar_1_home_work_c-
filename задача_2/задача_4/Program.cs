// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите первое число");
int firstnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int thirdnumber = int.Parse(Console.ReadLine());
int max = firstnumber;
if (secondnumber > max ) max = secondnumber;
if (thirdnumber > max ) max = thirdnumber;
Console.WriteLine("max = "+ max);
