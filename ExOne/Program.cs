Console.WriteLine("Введите первое целое число");
int firstNumber = System.Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int secondNumber = System.Convert.ToInt32(Console.ReadLine());

if ((Math.Pow(firstNumber, 2)) == secondNumber)
{
    Console.WriteLine("Второе число является квадратом первого");
}

else
{
    Console.WriteLine("Второе число не является квадратом первого");
}


