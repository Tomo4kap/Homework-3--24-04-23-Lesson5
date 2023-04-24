// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




Console.Clear();
Console.WriteLine("Задача 34 - найти количество чётных чисел в массиве");
Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];

for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(100, 1000);

    Console.Write($"{massive[i]} ");

}
int count = 0;

for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] % 2 == 0)
        count++;
}

Console.WriteLine();
Console.WriteLine($"В нашем массиве всего {massive.Length} трехзначных чисел, {count} из них чётные");





// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine();
Console.WriteLine("Задача 36 - найти сумму элементов на нечетных позициях");
Console.WriteLine("Введите длину массива");
int size1 = Convert.ToInt32(Console.ReadLine());
int[] massive1 = new int[size1];

for (int i = 0; i < massive1.Length; i++)
{
    massive1[i] = new Random().Next(-99, 100);

    Console.Write($"{massive1[i]} ");

}
int summ = 0;

for (int i = 0; i < massive1.Length; i++)
{
    if (massive1[i] % 2 == 0)
        summ = summ + massive1[i];
} //если позиция нечетная - то индекс четный!!!

Console.WriteLine();
Console.WriteLine($"Сумма чисел массива на нечетных позициях = {summ}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.WriteLine();
Console.WriteLine("Задача 38 - Найдите разницу между максимальным и минимальным элементов массива");

Console.Write("Введите количество элементов массива: ");

int size2 = Convert.ToInt32(Console.ReadLine());
double[] massive2 = new double[size2];

for (int i = 0; i < massive2.Length; i++)
{
    massive2[i] = new Random().Next(-99, 100);

    Console.Write($"{massive2[i]} ");

}
double min = massive2.Min();
double max = massive2.Max();

Console.WriteLine();
Console.WriteLine($"Min: {min}");          
Console.WriteLine($"Max: {max}");         
double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {difference}");