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

double[] massiv = new double[col];// массив для вывода суммы элементов столбца
for (int j = 0; j < col; j++)
	{
	   double sumcol = 0;
	  for (int i = 0; i < row; i++)
	    sumcol +=Array[i,j];
        massiv [j] =sumcol/row;//средняя арифметическая сумма 
        double summa=Math.Round( massiv [j],1); // округление средней ариф.суммы
     Console.Write($"S={summa}\t");
  
}  
