//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбов: ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] Array = new int[row, col];//основной массив

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        Array[i, j] = new Random().Next(100);
        Console.Write(Array[i, j]+"\t");
    }
     Console.WriteLine();
}

int[] massiv = new int[col];// массив для вывода суммы элементов столбца
for (int j = 0; j < col; j++)
	{
	   int sumcol = 0;
	  for (int i = 0; i < row; i++)
	    sumcol += Array[i,j];
        massiv [j] =sumcol;
     Console.Write($"S={massiv[j]}\t");
  
} 