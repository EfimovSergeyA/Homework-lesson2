// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
string num = Console.ReadLine();

if (num.Length >= 3)
   
{
    Console.WriteLine($"Третья цифра введённого числа: { num[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}