Console.WriteLine("Введите число a :");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b :");
int numberB = Convert.ToInt32(Console.ReadLine());

//лучше numberA * numberB - выводить в отдельную переменную 
int result = numberA * numberA;

if(result == numberB)
{
    Console.WriteLine("Да");
}
else
{
    Console.Write("Нет");
}

//Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого