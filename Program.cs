//Задайте два массива. 
//Напишите программу, которая будет находить произведение двух массивов.

int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size) //Создание массива
{
    return new int[size];
}

void FillArray(int[] array, int min, int max) //Заполнение массива
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max + 1);
}

void PrintArray(int[] array) //Вывод массива на экран
{
    //Console.Write("Ваш массив: ");
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}

void ProizvedArrays(int[] firstArray, int[] secondArray, int[] resultArray) //Произведение массивов
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        int sum = 0;
        sum += firstArray[i] * secondArray[i];
        resultArray[i] = sum;
    }
}

int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int [] firstArray = CreateArray(size); //Первый массив, создание, заполнение
FillArray(firstArray, minValue, maxValue);
Console.WriteLine($"\nВаш первый массив: ");
PrintArray(firstArray);

int[] secondArray = CreateArray(size); //Второй массив, создание, заполнение
FillArray(secondArray, minValue, maxValue);
Console.WriteLine($"\nВаш второй массив: ");
PrintArray(secondArray);

int[] resultArray = CreateArray(size); //Итоговый массив
ProizvedArrays(firstArray, secondArray, resultArray);
Console.WriteLine($"\nВаш умноженный массив: ");
PrintArray(resultArray);