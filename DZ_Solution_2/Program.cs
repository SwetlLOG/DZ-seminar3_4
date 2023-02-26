// Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов6 стоящих на нечетных позициях.
// [ 3, 7, 23, 12 ]-> 19    [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandom(numbers);
Console.WriteLine(" массив:");
PrintArray(numbers);

int Sum = 0; 
//int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if ( i %2 != 0) 
    {
        Sum = Sum + numbers[i];
    }
           
}


Console.WriteLine($"Сумма элементов, стоящиx на позициях c нечетными индексами: {Sum} ");

void FillArrayRandom(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(-10,100);
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