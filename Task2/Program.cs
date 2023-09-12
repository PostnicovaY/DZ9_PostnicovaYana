// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int N = 4, M = 8;
if (N > M) {
    Console.WriteLine(PrintNumber(M, N));
}
else if (N < M) {
    Console.WriteLine(PrintNumber(N, M));
}
else Console.WriteLine("Невозможно посчитать сумму чисел между элементами, т.к. они равны. ");

int PrintNumber(int n, int m)
{
    if (n == m) {
        return n;
    }
    return n + PrintNumber(n + 1, m);
}
