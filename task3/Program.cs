//Задача 29: Напишите программу, которая принимает на вход числа n, min, max. Затем генерирует массив размером n и заполняет его случайными числами в диапазоне от min до max.
//5, 1, 19 -> [1, 2, 5, 7, 19]
//3, 1, 33 -> [6, 1, 33]

int lenArray = ReadInt("Введите длинну массива: ");
int Min = ReadInt("Введите минимальное число: ");
int Max = ReadInt("Введите максимальное число: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(Min,Max);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}