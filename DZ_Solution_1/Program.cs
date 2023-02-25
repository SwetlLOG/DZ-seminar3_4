//задайте массив, заполненый случайными положительными трехзначными
//числами. Написать программу, которая покажет количество четных чисел в
// массиве [345, 897, 568, 234]-> 2

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandom(numbers);
Console.WriteLine(" массив:");
PrintArray(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i]%2 == 0)
count++;

Console.WriteLine($"Всего{numbers.Length} чисел, {count} из них четные");

void FillArrayRandom(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[");
    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

   
