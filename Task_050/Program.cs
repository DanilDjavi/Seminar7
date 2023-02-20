//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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
    int cCount = 4;
    double[,] array = makeArray(rCount, cCount);
    int rowNumber;
    int columnNumber;
    int indexNum=0;
    bool onceMore=true;
    Console.Clear();
    printArray(array);
    Console.WriteLine("Введите индексы без пробелов, сначало строка, затем колонка");
    indexNum = IntInput("");
    while (indexNum<10 && indexNum>=100)
    {
        Console.WriteLine($"indexNum = {indexNum}");
        Console.WriteLine($"Ошибка!!!");
    }

    rowNumber = indexNum / 10;
    columnNumber = indexNum % 10;
    
    if (rowNumber>rCount || columnNumber>cCount)
    {
        Console.WriteLine("Ошибка!!!");
    }
    else
    {
        printArray(array);
        Console.WriteLine($" Значение элемента массива: {array[rowNumber-1,columnNumber-1]}");
        Console.WriteLine();
    }