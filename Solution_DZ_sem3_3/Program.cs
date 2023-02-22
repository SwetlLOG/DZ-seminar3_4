// Напишите программу, которая принимает на вход число (N) и выдает
// таблицу кубов чисел от 1 до N.  3->1, 8, 27; 5->1, 8, 27,64,125

Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine()!);

String CubesNumbers(int n)
{
    double index = 1;
    double cube = 1;
    String result = " ";
    while (index <= n)

    {
        cube = Math.Pow(index , 3);
        result = (result + cube + ",");  
        index++;
    }
    
    return result;
}
    String Rescube = CubesNumbers(N);
    Console.WriteLine(Rescube);
    

