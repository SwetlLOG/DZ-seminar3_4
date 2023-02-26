//Задайте массив вещественных чисел. найдите разницу между максимальным 
//и минимальным элементом массива [ 3, 7, 22, 2, 78] -> 76

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandom(numbers);
Console.WriteLine(" массив: ");
PrintArray(numbers);

int max = numbers[0];

for (int imax = 1; imax < numbers.Length; imax++)
{
    if (numbers[imax] > max)
    {
        max = numbers[imax];
    }
}

int min = numbers[0];
for (int imin =1; imin < numbers.Length; imin++)
{
    if (numbers[imin]< min)
    {
        min = numbers[imin];
    }
}
int count = (max - min);
Console.WriteLine($"Массив{numbers.Length},разница между мин и макс {count } ");

void FillArrayRandom(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(1,100);
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

   

