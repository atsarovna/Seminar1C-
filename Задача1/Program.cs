{
    Console.WriteLine("Введите число a :");
    int numberA = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число b :");
    int numberB = Convert.ToInt32(Console.ReadLine());

    if(numberA * numberA == numberB)
    {
    Console.WriteLine("Да");
    }
    else
    {
    Console.Write("Нет");
    }
}
//Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого