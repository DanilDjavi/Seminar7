//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear(); 
for(int i = 1; i <= 3; i++) Console.WriteLine();

int IntInput(string intName)
{
    int num;

    Console.Write($"Введите число {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ошибка!!!");
    }
    return  num;
}

double[,] makeArray(int rowNum, int colNum)
{
    double[,] tdArray = new double[rowNum, colNum];
    Random rnd = new Random();
    for (int i = 0; i <= rowNum-1; i++)
    {
        for (int j=0; j <= colNum-1; j++)
        {
            tdArray[i,j] = Math.Round(rnd.NextDouble()+rnd.Next(-20,20), 1);
        }
    }
    return tdArray;
}

void printArray(double[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    string stringRes;
    for (int i = 0; i <= rows-1; i++)
    {
        for (int j = 0; j <= columns-1; j++)
        {
            
            stringRes = string.Format("{0:f2}", arr[i,j]);
            Console.Write(stringRes + "  ");
        }    
        Console.WriteLine();
    }

    for(int i=1; i<3; i++) Console.WriteLine();
   
}

int rCount = 3;
int cCount = 3;
double sumInColumn;
double[,] array = makeArray(rCount, cCount);
Console.WriteLine();
printArray(array);
for (int j = 0; j < cCount; j++)
{
    sumInColumn = 0;
    for (int i = 0; i < rCount; i++)
    {
        sumInColumn = sumInColumn + array[i,j];
    }
    string stringRes = string.Format("{0:f2}", sumInColumn/rCount);
        
    Console.WriteLine("Среднее арифметическое " + (j+1) + " колонки равна " + stringRes);
}