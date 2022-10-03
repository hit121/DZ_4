// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)  2, 4 -> 16

//double a = InputNumber();
//int b = Math.Abs(Convert.ToInt32(InputNumber()));

Console.Write("Введите число: ");
double a = Double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число: ");
int b = Int32.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(Power(a, b));

double Power(double x, int y)
{
    //double pow = Math.Pow(x, y);
    double pow = x;
    for(int i = 1; i < y; i++)
    {
        pow *= x;
    }
    return pow;
}




