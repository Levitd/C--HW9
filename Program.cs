using System;
using static System.Console;

Clear();

// Задача 64. Вывести натуральные числа от M до N. Используем рекурсию

/*
try
{
    Write("Вывести вcе натуральные числа в интервале от М до N. Введите М и N через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    WriteLine(PrintNumber(Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1])));

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}

string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumber(start + 1, end));
}
*/

//----------------------------------------------------------------------------------------------------------
// Задача 66. Сумма натуральных числет от M до N. Используем рекурсию
/*
try
{
    Write("Сумма натуральных числет от M до N. Введите М и N через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    WriteLine($"Сумма чисел равна: {SumNumber(Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1]))}");

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}

int SumNumber(int M, int N)
{
    if (M > N) return 0;
    return (M + SumNumber(M + 1, N));
}
*/


//----------------------------------------------------------------------------------------------------------
// Задача 68. Вычисление формулы Анкермана. Используем рекурсию

/*
try
{
    Write("Вычисление функции Анкермана. Введите m и n через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    WriteLine($"Значение функции Аккермана: {Akkernan(decimal.Parse(nums[0]), decimal.Parse(nums[1]))}");

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}
catch
{
    Write("Ошибка выполнения!");
}

decimal Akkernan(decimal m, decimal n)
{
    if (m == 0) return n+1;
    if (n ==0 && m>0) return Akkernan(m-1,1);
    if (m>0 && n>0) return Akkernan(m-1, Akkernan(m,n-1));
    else return 0;
}
*/

//----------------------------------------------------------------------------------------------------------
//Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную

try
{
    Write("Введите Десятичное число: ");
    int N = Convert.ToInt32(ReadLine());
    Write("Введите, в какую систему перевести: ");
    int sys = Convert.ToInt32(ReadLine());

    if (sys == 2 || sys == 8 || sys == 10 || sys == 16) // другие системы не предусмотрены в функции
    {
        string b1 = Convert.ToString(N, sys);
        WriteLine($"Через Convert             - {b1}");
    }

    string chars = "0123456789ABCDEF";
    WriteLine($"Через рекурсивную функцию - {DecToNums(N, sys, chars)}");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}
catch
{
   Write("Ошибка выполнения!");
}

// в любую систему исчисления от 2 до 16
string DecToNums(int Dec, int sys, string chars)
{
    if (Dec < sys)
        return ((Dec > 0) ? chars[Dec].ToString() : "");
    else
        return DecToNums(Dec / sys, sys, chars) + chars[(Dec % sys)].ToString();
}