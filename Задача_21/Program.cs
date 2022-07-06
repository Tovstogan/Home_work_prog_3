/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();
Console.WriteLine("Задача 21");

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int x1 = GetNumber("Введите координату x 1 точки");
int y1 = GetNumber("Введите координату y 1 точки");
int z1 = GetNumber("Введите координату z 1 точки");
int x2 = GetNumber("Введите координату x 2 точки");
int y2 = GetNumber("Введите координату y 2 точки");
int z2 = GetNumber("Введите координату z 2 точки");


double length = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между точками равняется {length}");
