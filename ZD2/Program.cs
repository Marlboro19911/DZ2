//Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.
// Не использовать строки для расчета.
// 645 -> 5;   78 -> третьей цифры нет;   326792 -> 6.
int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
int Result1(int num)
{
    if(num > 1000)
    {
        while (num >1000)
        {
            num = num / 10;
        }
    }
    num = num % 10;
    return num;
}
int num = InputInt ("Введите число");
if (num < 99)
{
    System.Console.WriteLine("У введённого числа нет третьей цифры");  
}
else
{
    int result = Result1(num);
    System.Console.WriteLine(result);
}