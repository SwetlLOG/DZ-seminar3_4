// Программа которая задает массив из четырех трехзначных чисел 
// и покажет количество четных чисел в массиве

//Ввод числа с экрана
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}
// Метод для получения случайных значений массива
int[] MainArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; //Обьявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random. Next(minValue, maxValue + 1);
    }
    return array;
}
void CratnAray(int[] Array)
{ 
    int counter = 0;
    //WriteLine("Элементыб кратные двум");

    for ( int j = 0; j < Array.Length; j++)
    {
        if (Array[j]%2 ==0) 
            counter++;
    }
}
        

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        System.Console.Write($"{array[i]},  ");//Вывод значения массива
    }
    System.Console.Write($"{array[array.Length -1]}");//вывод значения массива
    System.Console.WriteLine("]");
}
int length = Prompt("Длина массива:  ");
int min = Prompt("Начальное значение для случайных чисел:  ");
int max = Prompt("Конечное значение для случайных чисел:  ");
int[] array = MainArray(length, min, max);//заполнение массива случайными числами
PrintArray(array); //вывод массива
CratnAray(array);