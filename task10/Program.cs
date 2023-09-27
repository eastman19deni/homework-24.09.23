// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{

    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;

}

int number = Prompt("enter a three-digit number");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("YOur are enter not three digit number try again");
    return;
}
Console.WriteLine($"enter number {number}");
int secondRank = number / 10 % 10;
Console.WriteLine($"Second number {secondRank}");