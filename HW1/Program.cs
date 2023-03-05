Console.Clear();

Console.Write("Введите числа (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Количество чисел > 0: {count}");
