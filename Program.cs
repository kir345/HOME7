//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int rows = ReadInt("Введите номер строки: ");
int colums = ReadInt("Введите номер столбца: ");
int[,] nums = new int[3,4];
FillArray(nums);
PrintArray(nums);

if (rows < nums.GetLength(0) && colums < nums.GetLength(1)) Console.WriteLine(nums[rows, colums]);
else Console.WriteLine($"{rows}{colums} - такого числа в массиве нет");

void FillArray(int[,] array)
{
    for(int k = 0; k < array.GetLength(0); k++)
    {
        for(int i = 0; i < array.GetLength(1); i++)
        {
            array[k,i] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] array)
{
    for(int k = 0; k < array.GetLength(0); k++)
    {
        for(int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write(array[k,i] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}