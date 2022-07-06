/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/


Console.Clear();
Console.WriteLine("Задача 19");
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && (result>=10000 && result<=99999))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите корректное число.");
        }

    }

    return result;
}

int Number = GetNumber("Введите число");

    int number5 = Number % 10;
    int number4 = (Number/10)%10;
    int number3 = (Number/100)%10;
    int number2 = (Number/1000)%10;
    int number1 = (Number/10000);

if (number5== number1 && number4== number2)
{
    Console.WriteLine("Число является полиндромом");

}
else
{
        Console.WriteLine("Число не является полиндромом");
}