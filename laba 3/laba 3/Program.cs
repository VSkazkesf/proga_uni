﻿Random rnd = new Random();

static List<double> QuickSort(List<double> array)
{
    if (array.Count < 2)
    {
        return array;
    }

    int pivotIndex = new Random().Next(0, array.Count - 1);
    double pivot = array[pivotIndex];
    List<double> middle = new List<double>() { pivot };
    List<double> left = new List<double>();
    List<double> right = new List<double>();

    foreach (double i in array)
    {
        if (i < pivot)
        {
            left.Add(i);
        }
        if (i > pivot)
        {
            right.Add(i);
        }
    }

    List<double> rtrn = new List<double>();
    rtrn = rtrn.Concat(QuickSort(left).Concat(middle.Concat(QuickSort(right)))).ToList();
    return rtrn;
}

while (true)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("╔════════════════════════════════════╗");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("║             Вариант 1              ║");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("╠════════════════════════════════════╣");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("║         Выберите задание           ║");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("╠════════════════════════════════════╣");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("║1) Задание 1                        ║");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("║2) Задание 2                        ║");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("║3) Задание 3 (Лаб. работа 3.2)      ║");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("║0) Выход                            ║");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("╚════════════════════════════════════╝");
    Console.WriteLine("Введите номер задания:");
    int num_of_the_task = int.Parse(Console.ReadLine());
    switch (num_of_the_task)
    {
        case 1:
            {
                Console.WriteLine("Введите желаемую длину списка:");
                int n = int.Parse(Console.ReadLine());
                double[] array = new double[n];
                for (int i = 0; i < n; i++)
                {
                    int t1 = rnd.Next(-100, 100);
                    double t2 = rnd.NextDouble() * t1;
                    array[i] = Math.Round(t2, 4);
                }
                Console.WriteLine("Исходный список");
                Console.WriteLine(string.Join(" ", array));
                Console.WriteLine();
                Console.WriteLine();

                var min_value = array.Max();
                var max_value = array.Min();
                var left_ind = Array.IndexOf(array, min_value);
                var right_ind = Array.IndexOf(array, max_value);
                if (left_ind > right_ind)
                {
                    var temp = left_ind;
                    left_ind = right_ind;
                    right_ind = temp;
                }
                var sum_of_the_negative_num = 0.0;
                var product_between_min_max = 1.0;
                foreach (double i in array)
                {
                    if (i < 0)
                    {
                        sum_of_the_negative_num += i;
                    }

                    int digit_index = Array.IndexOf(array, i);
                    if (left_ind < digit_index)
                    {
                        if (digit_index < right_ind)
                        {
                            product_between_min_max *= array[digit_index];
                        }
                    }
                }

                List<double> unsorted_numbers = array.ToList();
                List<double> sortednumbers = QuickSort(unsorted_numbers);

                Console.WriteLine("Отсортированный по возрастанию список:");
                Console.WriteLine(string.Join(" ", sortednumbers));
                Console.WriteLine();
                Console.WriteLine("Сумма отрицательных элементов:");
                Console.WriteLine(Math.Round(sum_of_the_negative_num, 4));
                Console.WriteLine();
                Console.WriteLine("Произведение элементов между минимальным и максимальным:");
                Console.WriteLine(Math.Round(product_between_min_max, 4));
            }break;
            
        case 2:
            {
                int line_amount = int.Parse(Console.ReadLine());
                int column_amount = int.Parse(Console.ReadLine());
                int[] mtrx = new int[line_amount];
                for (int i = 0; i < line_amount; i++)
                {
                    int[] line = new int[column_amount];
                    for (int j = 0; j < column_amount; j++)
                    {
                         mtrx[i] = rnd.Next(-5, 5);
                    }
                }
            }break;

        case 3:
            {

            }
            break;

        case 0:
            {
                Console.WriteLine("Вы вышли из программы");
                return;
            }
        default:
            {
                Console.WriteLine("Такое действие не предусмотрено программой, попробуйте ввести другое значение");
            }break;

    }
    break;
}
