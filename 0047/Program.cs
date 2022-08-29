//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите число строк m: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число строк n: ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] Array = new double[row, columns];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Array[i, j] = new Random().NextDouble()*10;
        double ElementArray = Math.Round(Array[i, j],1);
        Console.Write(ElementArray+"\t");
    }
     Console.WriteLine();
}




