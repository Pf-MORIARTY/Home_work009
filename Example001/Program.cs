//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int A = InputInt("Введите положительное число - ");
int B = 1;
Console.WriteLine(NaturalNumber(A, B));

int NaturalNumber(int A, int B)
{
    if (A == B)
        return A;
    else
        Console.Write($"{NaturalNumber(A, B + 1)}, ");
    return B;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}