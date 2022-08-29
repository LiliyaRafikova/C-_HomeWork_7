// //  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Определим размер массива!");
Console.Write("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] Array = new int[row, columns];

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Array[i, j] = new Random().Next(100);
        Console.Write(Array[i, j]+"\t");
    }
     Console.WriteLine();
}
Console.Write("Укажите номер строки позиции : ");
int rowX = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите номер столбца позиции : ");
int columnsX = Convert.ToInt32(Console.ReadLine());
if ((rowX -1)<0 || (rowX -1)>(row-1) ||(columnsX-1)<0 || (columnsX-1)>(columns-1)) 
Console.Write("Такого элемента нет!");
else
    for (int i = 0; i < row; i++)
    {
    for (int j = 0; j < columns; j++)
    {
        if ((i == rowX-1) && (j== columnsX-1))
         Console.WriteLine($" Array[{rowX};{columnsX}] = {Array[i, j]}");
              
    }
    }

    
   