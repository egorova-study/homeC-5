// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDbl(int size, double min, double max) 
{ 
    double[] array = new double [size]; 
    
    Random rnd = new Random();
    for (int i = 0; i < size; i++) 
    {
        array[i] = Math.Round(rnd.NextDouble()*(max-min)+min, 2); 
    }
    return array; 
}

void PrintArray (double[] array) 
{
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, "); 
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] arr = CreateArrayRndDbl(4, 1.0, 100.0); 
PrintArray(arr);


double FindDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }

    double difference = max - min;
    return difference;
}

Console.WriteLine($"max - min = {FindDifference(arr)}");