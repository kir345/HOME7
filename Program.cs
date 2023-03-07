// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
double[,] nums = new double[3,4];
FillArray(nums);
PrintArray(nums);

void FillArray(double[,] array)
{
    for(int k = 0; k < array.GetLength(0); k++)
    {
        for(int i = 0; i < array.GetLength(1); i++)
        {
            array[k,i] = new Random().Next();
        }
    }
}
void PrintArray(double[,] array)
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