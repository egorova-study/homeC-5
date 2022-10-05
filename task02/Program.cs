// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max) //метод создающий массив, заполненый рандомными целыми числами(int size - параметр массива который будем передавать)
{ //тело метода
    int[] array = new int [size]; //имя массива = тип массива(инт) и [длина массива]
    // ниже введем генератов псевдослучайных чисел, для этого сначала создадим объект (который потом применяем в цикле):
    Random rnd = new Random();
    for (int i = 0; i < size; i++) //создали цикл фор (i=0 индекс. счетчик начнется с него)
    {
        array[i] = rnd.Next(min, max + 1); //генерируем псевдослуч числа в диапазоне
    }
    return array; // возвращаем этот массив
}

void PrintArray (int[] array) //выводим массив
{
    Console.Write("["); //чтобы массив был в квадр скобках
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, "); //чтобы элементы были через запятую
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(4, -99, 100); //создаем переменную-массив с соотв параметрами
PrintArray(arr); //выводим


int GetSum (int[] array)
{
    int getSum = default;
    for (int i = 1; i < array.Length; i+= 2)
    {
        getSum = getSum + array [i]; //+= означает накопление значений sumPositive = sumPositive + array [i]
    }
    return getSum;
}   

int getSum = GetSum (arr);
Console.WriteLine($"сумма нечетных элементов = {getSum}");