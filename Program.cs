// Задача 64:
// Выполнить с помощью рекурсии.
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа 
// в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// int N = new Random().Next(5, 15);
// Console.WriteLine(N);
// Console.WriteLine(Numbers(N, 1));


// //  --- Method ---

// string Numbers(int start, int finish)
// {
//     if (start == finish)
//     {
//         return start.ToString();
//     }
//     else
//     {
//         return (start + ", " + Numbers(start - 1, finish));
//     }
// }


// Задача 66:
// Выполнить с помощью рекурсии.Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных

// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int M = new Random().Next(5);
// int N = new Random().Next(7, 15);
// System.Console.WriteLine($"Задан диапазон: от  {M} до {N}.");
// Console.WriteLine($"Сумма элементов = {SumNumbers(M, N)}");

// //  --- Method ---

// int SumNumbers(int M, int N)
// {
//     if (M == 0) return (N * (N + 1)) / 2;
//     else if (N == 0) return (M * (M + 1)) / 2;
//     else if (M == N) return M;
//     else if (M < N) return N + SumNumbers(M, N - 1);
//     else return N + SumNumbers(M, N + 1);
// }


// Задача 68:
// Выполнить с помощью рекурсии.Напишите программу
// вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29