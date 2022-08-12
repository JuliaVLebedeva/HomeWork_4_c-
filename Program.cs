//Урок 4. Функции продолжение
//Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень для числа");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = a;

    for (int i = 1; i < b; i++)
    {
        result *= a;
    }

    Console.WriteLine($"Результат возведения числа {a} в степень {b} = {result}");
}


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//1 ВАРИАНТ

{
    Console.WriteLine("Введите число");
    int numb = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    
        while(numb > 0)
    {
        sum += numb%10;
        numb /= 10;
    }
    Console.WriteLine($"Сумма цифр числа {numb} Равна {sum}");
}

Почему выходит 0. Как сделать красивое оформление, чтобы всё прописать в одной строчке и получать результат
Введите число
16
Сумма цифр числа 0 Равна 7


//2 ВАРИАНТ
{
    int number = 18675;
    SumOfDigits(number);
}

void SumOfDigits(int numb)
{
    int sum = 0;
    Console.WriteLine("Сумма цифр числа " + numb);
    while(numb > 0)
    {
        sum += numb%10;
        numb /= 10;
    }
    Console.WriteLine("Равна " + sum);
}


//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

{
    int size = 8;
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();


    for (int i = array.Length - 1; i > 0; i--)
    {
        for (int k = 0; k < i; k++)
        {
            if (Math.Abs(array[k]) > Math.Abs(array [k+1]))
            {
                int temp = array[k];
                array[k] = array[k+1];
                array[k+1] = temp;
            }
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

