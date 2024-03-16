//Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ.
//Используйте обработку исключений для защиты от ввода некорректных данных.
try
{
    Console.WriteLine("Введите число 1");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 2");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите код операции");
    int code = Convert.ToInt32(Console.ReadLine());
    if (code==1)
    {
        Console.WriteLine($"{a}+{b}={a+b}");
    }

    else if (code == 2)
    {
        Console.WriteLine($"{a}-{b}={a-b}");
    }

    else if (code == 3)
    {
        Console.WriteLine($"{a}*{b}={a * b}");
    }

    else if (code == 4)
    {
        Console.WriteLine($"{a}/{b}={(double)(a)/b}");
    }
}
catch (Exception ex)
{
    
        Console.WriteLine(ex.Message);
    }
    


Console.ReadKey();
