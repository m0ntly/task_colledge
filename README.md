# Задания Циклы .NET Framework 4.8

## Задание 1

```c#
using System;

class HelloWorld 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("Введите количество месяцев:");
        int months = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < months; i++)
            {
                deposit += deposit * 0.07m;
            }
        
        Console.WriteLine($"Итоговая сумма вклада: {deposit:F2}");
    }
}
```

## Задание 2

```c#
using System;

class HelloWorld 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("Введите количество месяцев:");
        int months = Convert.ToInt32(Console.ReadLine());
        
        int currentMonth = 0;
        while (currentMonth < months)
        {
            deposit += deposit * 0.07m;
                        currentMonth++;
        }
        
        Console.WriteLine($"Итоговая сумма вклада: {deposit:F2}");
    }
}
```

## Задание 3

```c#
using System;

class HelloWorld 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Таблица умножения:");
        
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j}\t");
            }
        Console.WriteLine();
        }
    }
}
```

## Задание 4

```c#
using System;

class HelloWorld 
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите первое число (0-10):");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите второе число (0-10):");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
            {
                Console.WriteLine($"Результат умножения: {num1 * num2}");
                break;
            }
            else
            {
                Console.WriteLine("Введенные числа недопустимы. Оба числа должны быть от 0 до 10.");
            }
        }
    }
}
```

## [Вернутся на главную](https://github.com/m0ntly/task_colledge)
