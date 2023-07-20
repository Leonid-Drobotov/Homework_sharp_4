// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number_input = int.Parse(Console.ReadLine());

int SumNumber(int number_input)
{

    int size = Convert.ToString(number_input).Length;
    int step = 0;
    int sum = 0;

    for (int i = 0; i < size; i++)
    {
        step = number_input - number_input % 10;
        sum = sum + (number_input - step);
        number_input = number_input / 10;
    }
    return sum;
}

int sumNumber = SumNumber(number_input);
Console.WriteLine($"{number_input} -> {sumNumber}");
