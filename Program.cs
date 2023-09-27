Console.Write("Введите номер задачи: ");
int a = 0;
try{
a = Convert.ToInt32(Console.ReadLine());
} catch (System.FormatException){
    Console.Write("Это не номер");
    return;
}

switch (a){

    case 64:
    task64();
    break;

    case 66:
    task66();
    break;

    case 68:
    task68();
    break;

    default: 
    Console.WriteLine("Нет такой задачи(");
    break;
}

// Task64. Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

void task64(){
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        if (N < 1)
        {
            Console.WriteLine("N должно быть больше или равно 1.");
        }
        else
        {
            Console.WriteLine("Натуральные числа в промежутке от " + N + " до 1:");

            PrintNaturalNumbers(N);

            Console.ReadLine();
        }

    static void PrintNaturalNumbers(int n)
    {
        if (n >= 1)
        {
            Console.WriteLine(n); // Выводим текущее число
            PrintNaturalNumbers(n - 1); // Рекурсивно вызываем функцию для следующего числа
        }
    }
}

// Task66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.

void task66(){
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (M <= 0 || N <= 0 || M > N)
        {
            Console.WriteLine("M и N должны быть положительными числами, и M должно быть меньше или равно N.");
        }
        else
        {
            int sum = SumNaturalNumbers(M, N);

            Console.WriteLine("Сумма натуральных чисел в промежутке от " + M + " до " + N + " равна: " + sum);

            Console.ReadLine();
        }

    static int SumNaturalNumbers(int M, int N)
    {
        if (M == N)
        {
            return M;
        }
        else
        {
            return M + SumNaturalNumbers(M + 1, N);
        }
    }
}

// Task68. Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

void task68(){
   
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        if (m < 0 || n < 0)
        {
            Console.WriteLine("m и n должны быть неотрицательными числами.");
        }
        else
        {
            int result = AckermannFunction(m, n);

            Console.WriteLine("Значение функции Аккермана для m = " + m + " и n = " + n + " равно " + result);

            Console.ReadLine();
        }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        else
        {
            throw new ArgumentException("Функция Аккермана определена только для неотрицательных целых чисел.");
        }
    }
}