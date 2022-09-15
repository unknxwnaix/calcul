

    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
int NumOpI1SS = 1;
while (NumOpI1SS != 9)
{
    Console.Write("Выберите операцию: ");
    string NumOpS = Console.ReadLine();
    int NumOpI = Convert.ToInt32(NumOpS);
    NumOpI1SS = NumOpI;
    if (NumOpI == 1)
    {
        Console.Write("Выберите первое число: ");
        string Num1S = Console.ReadLine();
        Console.Write("Выберите второе число: ");
        string Num2S = Console.ReadLine();
        int Num1I, Num2I;
        Num1I = Convert.ToInt32(Num1S);
        Num2I = Convert.ToInt32(Num2S);
        int result = Num1I + Num2I;
        Console.WriteLine("Результат: " + result);
        Console.WriteLine();
    }
    else if (NumOpI == 2)
    {
        Console.Write("Выберите первое число: ");
        string Num1S = Console.ReadLine();
        Console.Write("Выберите второе число: ");
        string Num2S = Console.ReadLine();
        int Num1I, Num2I;
        Num1I = Convert.ToInt32(Num1S);
        Num2I = Convert.ToInt32(Num2S);
        int result = Num2I - Num1I;
        Console.WriteLine("Результат: " + result);
        Console.WriteLine();
    }
    else if (NumOpI == 3)
    {
        Console.Write("Выберите первое число: ");
        string Num1S = Console.ReadLine();
        Console.Write("Выберите второе число: ");
        string Num2S = Console.ReadLine();
        int Num1I, Num2I;
        Num1I = Convert.ToInt32(Num1S);
        Num2I = Convert.ToInt32(Num2S);
        int result = Num1I * Num2I;
        Console.WriteLine("Результат: " + result);
        Console.WriteLine();
    }
    else if (NumOpI == 4)
    {
        Console.Write("Выберите первое число: ");
        string Num1S = Console.ReadLine();
        Console.Write("Выберите второе число: ");
        string Num2S = Console.ReadLine();
        int Num1I, Num2I;
        Num1I = Convert.ToInt32(Num1S);
        Num2I = Convert.ToInt32(Num2S);
        int result = Num1I / Num2I;
        Console.WriteLine("Результат: " + result);
        Console.WriteLine();
    }
    else if (NumOpI == 5)
    {
        Console.Write("Выберите число: ");
        string Num1S = Console.ReadLine();
        int Num1I;
        Num1I = Convert.ToInt32(Num1S);
        Console.Write("Введите степень N: ");
        String PokazatelStepeniS = Console.ReadLine();
        int PokazatelStepeniI = Convert.ToInt32(PokazatelStepeniS);
        int result = 1;
        int schetchik = 1;
        for (schetchik = 1; schetchik <= PokazatelStepeniI; schetchik++)
        {
            result = Num1I * result;
        }
        Console.WriteLine("Результат: " + result);
        Console.WriteLine();
    }
    else if (NumOpI == 6)
    {
        Console.Write("Выберите число: ");
        string Num1S = Console.ReadLine();
        int Num1I;
        Num1I = Convert.ToInt32(Num1S);
        int result = Convert.ToInt32(Math.Sqrt(Num1I));
        Console.WriteLine("Результат: " + result);
        Console.WriteLine();
    }
    else if (NumOpI == 7)
    {
        Console.Write("Выберите число: ");
        string Num1S = Console.ReadLine();
        int Num1I;
        Num1I = Convert.ToInt32(Num1S);
        double result = Convert.ToDouble(Num1I * 0.01);
        Console.WriteLine("Результат: " + result);
        Console.WriteLine();
    }
    else if (NumOpI == 8)
    {
        Console.Write("Выберите число: ");
        string Num1S = Console.ReadLine();
        int Num1I;
        Num1I = Convert.ToInt32(Num1S);
        int factorial = 1;

        for (int i = 2; i <= Num1I; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("Результат: " + factorial);
        Console.WriteLine();
    }
    else break;

}