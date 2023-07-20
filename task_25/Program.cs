// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int number_input, int number_pow_input)
{
    int Pow = 1;
    for (int i = 1; i <= number_pow_input; i++)
    {
        Pow = Pow * number_input;
    }

    return Pow;
}

Console.Write("Введите число: ");
int number_input = int.Parse(Console.ReadLine());
Console.Write("Введите степень в которе возведем число: ");
int number_pow_input = int.Parse(Console.ReadLine());

int exponentiation = Exponentiation(number_input, number_pow_input);
Console.WriteLine($"{number_input} -> {exponentiation}");
