// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void EvenNumbersCount()
{
int [] num = new int[23];
int j = 0; // Счётчик количества чётных чисел в массиве.
List<int> myEvens = new List<int>(); // Список чётных чисел
for (int i = 0; i < 23; i++)
    {
        num[i] = new Random().Next(100, 1000);
        if (num[i] % 2 == 0)
        {
            j++;
            myEvens.Add(num[i]);
        }
    }

var evens = myEvens.ToArray();

Console.WriteLine();
Console.WriteLine("Создан массив случайных чисел: " + String.Join(", ", num) + ".");
Console.WriteLine();
Console.WriteLine($"Созданный массив соодержит {j} чётных чисел.");
Console.WriteLine();
Console.WriteLine("Список чётных чисел: " + String.Join(", ", evens) + ".");
Console.WriteLine();
}
EvenNumbersCount();