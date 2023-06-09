// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNumbers (int num)
{   
    Console.Write (num + " ");
    if (num >1) ShowNumbers(num - 1);
}
ShowNumbers(13);

*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int SummNum (int numM, int numN)
{
    if (numM < numN) return SummNum (numM + 1, numN) + numM;
    else return numM;
}
int summ = SummNum(1,9);
Console.Write (summ);

*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
double FunAkk (double m, double n)
{
    if(m == 0) return n + 1;
    if(n == 0) return FunAkk(m-1,1);
    if(n > 0) return FunAkk(m-1, FunAkk(m,n-1));
    else return n;
}

double akk = FunAkk(3,2);
Console.Write (akk);
*/