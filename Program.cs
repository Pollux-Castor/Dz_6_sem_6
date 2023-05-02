// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Ведите длинну массива");
// int N= Convert.ToInt32(Console.ReadLine());
// int numP=0;
// int[] Massiv = new int[N];
// for (int i=0;i<Massiv.Length;i++)
// {
// Console.WriteLine("Введите элемент массива");
// Massiv [i] = Convert.ToInt32(Console.ReadLine());

//         if (Massiv [i]>0 )
//             {
//                 numP=numP+1;
//             }
// }
// Console.WriteLine();
// Console.WriteLine($"Исходный массив: {String.Join(" | ",Massiv)}");
// Console.WriteLine($"Количество чисел больше 0 в массиве: {numP}");

// -------------------------------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Введите переменную b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

// Console.Write($"Точка пересечения двух прямых: [{x},{y}]");

