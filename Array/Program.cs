// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Security.Cryptography;
using static System.Console;
//Write("Введите количество элементов массива: "); //Запрос колическ=тва элементов в ручну из консоли
//int elementCount = int.Parse(ReadLine()); //Ввод колическ=тва элементов в ручну из консоли
int elementCount = 5;
int[] A = new int[elementCount];
void FillingArray()
{
    
    
    WriteLine("Заполнение одномерного массива с клавиатуры:");

    for (int i = 0; i < elementCount; i++)
    {
        Write($"Введите элемент массива под индексом {i}: ");
        A[i] = int.Parse(ReadLine());
    }

}
void PrintArray()
{
    WriteLine();
    WriteLine("Проверка заполненности массива A");
    for (int i = 0; i < elementCount; i++)
    {
        Write(A[i] + "\t");
    }
    WriteLine();
}

void MinArray()
{
var min = A.Min();
WriteLine($"В массиве А минимальное число {min}");
}
void MaxArray()
{
var max = A.Max();
    WriteLine($"В массиве А максимальное число {max}");
}
void SumArray()
{
var sum = A.Sum();
WriteLine($"В массиве А общая сумма всех элементов {sum}");
}

double[,] B = new double[3,4];

Random ran = new Random();
void FillingArray2D()
{
    WriteLine();
    WriteLine("Проверкка заполнения двумерного массива B");
   
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            B[i, j] = ran.NextDouble() * 5;
            Write(B[i, j] + "\t");
        }
        WriteLine();
    }
}




int pr = 1;
int EvenSum = 0;
int NotAlone = 0;


void PrAndSum()
{
    for (int i = 0; i < A.Length; i++)
    {
        pr = pr * A[i];
        int buffer = A[i];
        if (buffer % 2 == 0)
        {
            NotAlone++;
            if (NotAlone >=1)
            {
            EvenSum = EvenSum + buffer;
            }
        }
    }

    WriteLine($"В массиве A произведение равно {pr}");
    if (EvenSum>0 & NotAlone >1)
    {
        WriteLine($"В массиве A сумма четных элементов равна {EvenSum}");
    }
    else if (EvenSum ==0 & NotAlone < 1)
    {
        WriteLine($"В массиве A нет чётных элементов для сумирования");

    }
    else if (NotAlone == 1)
    {
        WriteLine("В массиве A всего один чётный элемент, суммирование не целесообразно");
    }
}



int rows = B.GetLength(0);//B.GetUpperBound(0)+1;
int columns = B.GetLength(1);
int dimension = B.Length;


void PrintSpecificationsArray2D()
{
    WriteLine();
    WriteLine($"В массиве В строк {rows}, столбцов {columns}, всего элементов {dimension}");
}

void Array2DMath()
{
    double maxB = B[0, 0];
    double minB = B[0, 0];
    double sumB = 0.0;
    double prB = 1.0;
    double OddSumB = 0.0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (B[i, j] > maxB) { maxB = B[i, j]; }
            if (B[i, j] < minB) { minB = B[i, j]; }
            sumB += B[i, j];
            prB = prB * B[i, j];
            if (j % 2 != 0) { OddSumB = OddSumB + B[i, j]; }
        }
    }
    WriteLine($"В массиве В Max = {maxB}, Min = {minB}");
    WriteLine($"В массиве В общая сумма всех элементов {sumB}");
    WriteLine($"В массиве В произведение равно {prB}");
    WriteLine($"В массиве В сумма не четных столбцов равна {OddSumB}");

}



string[] menuItem = new string[] {"Программа - 1 \"Работа с Одномерным и Двумерным массивами\"", "Программа - 2 \"Сумма элементов в промежутке Min-Max\"", "Программа - 3", "Программа - 4", "Программа - 5", "Программа - 6", "Программа - 7", "Программа - 8 \"Выход из программы\"" };

foreach (string menu in menuItem)
{
    WriteLine(menu);
}
WriteLine();
WriteLine("Выберите программу с которой хотите работать");
Write(">> "); 
String str = ReadLine();

int[,] Array2D_2 = new int[5, 5];

int RowsArray2D_2 = Array2D_2.GetLength(0);//B.GetUpperBound(0)+1;
int ColumnsArray2D_2 = Array2D_2.GetLength(1);
int DimensionArray2D_2 = Array2D_2.Length;

void PrintSpecificationsArray2D_2()
{
    WriteLine($"В массиве Array2D_2 строк {RowsArray2D_2}, столбцов {ColumnsArray2D_2}, всего элементов {DimensionArray2D_2}");
    WriteLine();
}
void FillingArray2D_2()
{
 
    WriteLine("Проверкка заполнения двумерного массива Array2D_2 в диапазоне от -100 до 100");
    for (int i = 0; i < RowsArray2D_2; i++)
    {
        for (int j = 0; j < ColumnsArray2D_2; j++)
        {
        Array2D_2[i, j] = ran.Next(-100,100);
            int result = Array2D_2[i, j];
            if (result>0)
            { Write(" " + result + "\t"); }
            if (result<0)
            {
            Write(result + "\t");
            }
        }
        WriteLine();
            
    }
}


int MaxArray2D_2()
{
    int maxArray2D_2 = Array2D_2[0, 0];
    for (int i = 0; i < RowsArray2D_2; i++)
    {
        for (int j = 0; j < ColumnsArray2D_2; j++)
        {
            if (Array2D_2[i, j] > maxArray2D_2) { maxArray2D_2 = Array2D_2[i, j]; }
        }
    }
    WriteLine();
    WriteLine($"В массиве Array2D_2 Max = {maxArray2D_2}");
    return maxArray2D_2;
}

int MinArray2D_2()
{
    int minArray2D_2 = Array2D_2[0, 0];
    for (int i = 0; i < RowsArray2D_2; i++)
    {
        for (int j = 0; j < ColumnsArray2D_2; j++)
        {
            if (Array2D_2[i, j] < minArray2D_2) { minArray2D_2 = Array2D_2[i, j]; }
        }
    }

    WriteLine();
    WriteLine($"В массиве Array2D_2 Min = {minArray2D_2}");
    return minArray2D_2;
}
void Coordinates(int maxArray2D_2, int minArray2D_2 )
{
    int MaxBufferI = 0;
    int MinBufferI = 0;
    int MaxBufferJ = 0;
    int MinBufferJ = 0;
    for (int i = 0; i < RowsArray2D_2; i++)
    {
        for (int j = 0; j < ColumnsArray2D_2; j++)
        {
            if (Array2D_2[i,j] == maxArray2D_2) { MaxBufferI = i; MaxBufferJ = j; }
            if (Array2D_2[i,j] == minArray2D_2) { MinBufferI = i; MinBufferJ = j; }
        }
    }
    WriteLine($"Координаты Nax = {MaxBufferI},{MaxBufferJ}");
    WriteLine($"Координаты Min = {MinBufferI},{MinBufferJ}");
}

switch (str)
    {
     case "1":
        Clear();
        FillingArray();
        PrintArray();
        FillingArray2D();
        WriteLine();
        MinArray();
        MaxArray();
        SumArray();
        PrAndSum();
        PrintSpecificationsArray2D();
        Array2DMath();
        break;
     case "2":
        Clear();
        PrintSpecificationsArray2D_2();
        FillingArray2D_2();
        //MaxArray2D_2();
        //MinArray2D_2();
        Coordinates(MaxArray2D_2(),MinArray2D_2());
        break;
     case "3":
        WriteLine("3");
        break;
     case "4":
        WriteLine("4");
        break;
     case "5":
        WriteLine("5");
        break;
     case "6":
        WriteLine("6");
        break;
     case "7":
        WriteLine("7");
        break;
     case "8":
        WriteLine("8");
        break;
     default:
        WriteLine("Выбран неверный пункт меню");
        break;

    }