// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите первое число");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите четвертое число");
int a4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите пятое число");
int a5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите шестое число");
int a6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите седьмое число");
int a7 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите восьмое число");
int a8 = Convert.ToInt32(Console.ReadLine());

int [] array = new int [8] {a1, a2, a3, a4, a5, a6, a7, a8};

int i = 0;

while(i < array.Length)
{
Console.Write(array[i] + ", ");
i++;
}