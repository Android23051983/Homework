﻿// See https://aka.ms/new-console-template for more information
#define TASK_1
#define TASK_2
#define TASK_3
#define TASK_4
#define TASK_5
#define TASK_6
#define TASK_7
using System.Buffers;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using static System.Console;
//Write("Введите количество элементов массива: "); //Запрос колическ=тва элементов в ручну из консоли
//int elementCount = int.Parse(ReadLine()); //Ввод колическ=тва элементов в ручну из консоли

#if TASK_1
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

double[,] B = new double[3, 4];

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
            if (NotAlone >= 1)
            {
                EvenSum = EvenSum + buffer;
            }
        }
    }

    WriteLine($"В массиве A произведение равно {pr}");
    if (EvenSum > 0 & NotAlone > 1)
    {
        WriteLine($"В массиве A сумма четных элементов равна {EvenSum}");
    }
    else if (EvenSum == 0 & NotAlone < 1)
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
#endif


#if TASK_2
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
            Array2D_2[i, j] = ran.Next(-100, 100);
            int result = Array2D_2[i, j];
            if (result > 0){ Write(" " + result + "\t");}
            if (result < 0)
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
void Coordinates(int maxArray2D_2, int minArray2D_2)
{
    int MaxBufferI = 0;
    int MinBufferI = 0;
    int MaxBufferJ = 0;
    int MinBufferJ = 0;
    int Sum = 0;
    for (int i = 0; i < RowsArray2D_2; i++)
    {
        for (int j = 0; j < ColumnsArray2D_2; j++)
        {
            if (Array2D_2[i, j] == maxArray2D_2) { MaxBufferI = i; MaxBufferJ = j; }
            if (Array2D_2[i, j] == minArray2D_2) { MinBufferI = i; MinBufferJ = j; }
        }
    }
    WriteLine($"Координаты Nax = {MaxBufferI},{MaxBufferJ}");
    WriteLine($"Координаты Min = {MinBufferI},{MinBufferJ}");

    int StartBufferIArray2D_2 = 0;
    int StartBufferJArray2D_2 = 0;
    int EndBufferIArray2D_2 = 0;
    int EndBufferJArray2D_2 = 0;

    if (MaxBufferI > MinBufferI)
    {
        StartBufferIArray2D_2 = MinBufferI;
        StartBufferJArray2D_2 = MinBufferJ;
        EndBufferIArray2D_2 = MaxBufferI;
        EndBufferJArray2D_2 = MaxBufferJ;
    }
    else if (MaxBufferI < MinBufferI)
    {
        StartBufferIArray2D_2 = MaxBufferI;
        StartBufferJArray2D_2 = MaxBufferJ;
        EndBufferIArray2D_2 = MinBufferI;
        EndBufferJArray2D_2 = MinBufferJ;

    }
    else if (MaxBufferI == MinBufferI)
    {
        if (MaxBufferJ > MinBufferJ)
        {
            StartBufferIArray2D_2 = MinBufferI;
            StartBufferJArray2D_2 = MinBufferJ;
            EndBufferIArray2D_2 = MaxBufferI;
            EndBufferJArray2D_2 = MaxBufferJ;
        }
        else if (MaxBufferJ < MinBufferJ)
        {
            StartBufferIArray2D_2 = MaxBufferI;
            StartBufferJArray2D_2 = MaxBufferJ;
            EndBufferIArray2D_2 = MinBufferI;
            EndBufferJArray2D_2 = MinBufferJ;

        }
    }

    WriteLine($"Старт диапазона элементов {StartBufferIArray2D_2},{StartBufferJArray2D_2}");
    WriteLine($"Конец диапазона элементов {EndBufferIArray2D_2},{EndBufferJArray2D_2}");

    int SumArray2D_2 = 0;
    for (int i = StartBufferIArray2D_2; i <= EndBufferIArray2D_2; i++)
    {
        if (i == StartBufferIArray2D_2 & i != EndBufferIArray2D_2)
        {
            for (int j = StartBufferJArray2D_2; j < Array2D_2.GetLength(1); j++)
            {
                SumArray2D_2 = SumArray2D_2 + Array2D_2[i,j];
                Write(Array2D_2[i, j] + "\t");
            }
            WriteLine();
        }
        if (i == StartBufferIArray2D_2 & i == EndBufferIArray2D_2)
        {
            for(int j=StartBufferJArray2D_2; j<=EndBufferJArray2D_2; j++)
            {
                SumArray2D_2 = SumArray2D_2 + Array2D_2[i, j];
                Write(Array2D_2[i, j] + "\t");
            }
        }

        if (i > StartBufferIArray2D_2 & i < EndBufferIArray2D_2)
        {
            for (int j = 0; j < Array2D_2.GetLength(1); j++)
            {
                SumArray2D_2 = SumArray2D_2 + Array2D_2[i, j];
                Write(Array2D_2[i, j]+"\t");
            }
            WriteLine();
        }
         if (i!=StartBufferIArray2D_2 & i == EndBufferIArray2D_2)
        {
            for (int j = 0; j <= EndBufferJArray2D_2; j++)
            {
                SumArray2D_2 = SumArray2D_2 + Array2D_2[i, j];
                Write(Array2D_2[i, j] + "\t");
            }
            WriteLine();
        }
        
        WriteLine();
    }
    WriteLine($"Сумма элементов в диапазоне от {StartBufferIArray2D_2},{StartBufferJArray2D_2} до {EndBufferIArray2D_2},{EndBufferJArray2D_2} равна {SumArray2D_2}");


}

#endif

#if TASK_3

#endif

#if TASK_4
int[,] Array1_2D_4 = new int[4, 6];
int[,] Array2_2D_4 = new int[6, 4];

void FillingMatrixArray2D_4(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            WriteLine($"Введите элемент ячейки {i},{j}");
            int Element = int.Parse(ReadLine());
            arr[i, j] = Element;
        }
    }

}

void PrintMatrixArray2D_4(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write(arr[i,j] +"\t");
        }
        WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {
    if (matrixA.GetUpperBound(1)+1 != matrixB.GetUpperBound(0)+1)
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (var i = 0; i < matrixA.GetUpperBound(0)+1; i++)
    {
        for (var j = 0; j < matrixB.GetUpperBound(1)+1; j++)
        {
            matrixC[i, j] = 0;

            for (var k = 0; k < matrixA.GetUpperBound(1)+1; k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}
int[,] MatrixMultiplicationByNumber( int[,] arr, int мultiplier )
{ 
    var matrixM = new int[arr.GetLength(0), arr.GetLength(1)];
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            matrixM[i,j] = arr[i,j] * мultiplier;
        }
    }
    return matrixM;
}
int[,] SumArr2D_4(int[,] arr, int[,] arr2 )
{
    if (arr.GetUpperBound(1) + 1 != arr2.GetUpperBound(0) + 1)
    {
        throw new Exception("Сложение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    var matrixS = new int[arr.GetLength(0), arr2.GetLength(1)];

    for (var i = 0; i < arr.GetUpperBound(0) + 1; i++)
    {
        for (var j = 0; j < arr2.GetUpperBound(1) + 1; j++)
        {
            matrixS[i, j] = 0;

            for (var k = 0; k < arr.GetUpperBound(1) + 1; k++)
            {
                matrixS[i, j] += arr[i, k] + arr2[k, j];
            }
        }
    }
        return matrixS;
}

#endif

#if TASK_5
void MathPlusMinus()
{
    WriteLine("Введите арифметическое выражение");
    string text_5 = ReadLine();
    WriteLine();
    //WriteLine(text);
    double a = 0;
    double b = 0;
    int buffer = 0;
    double total = 0;
    string str = "";
    char[] chars_5 = text_5.ToCharArray();
    text_5 = text_5.Replace(".", ",");
    string[] variables = text_5.Split('+', '-', '/', '*');
    foreach(var result in variables)
    {
        WriteLine(result);
    }
    //WriteLine(text_5);

    //for (int i=0 ; i <= chars_5.Length-1; i++) 
    //{

    //    switch (chars_5[i])
    //    {
    //        case '*':
    //            buffer = i - 1;
    //            str = Convert.ToString(chars_5[buffer]);
    //            a = Convert.ToDouble(str);
    //            buffer = i + 1;
    //            str = Convert.ToString(chars_5[buffer]);
    //            b = Convert.ToDouble(str);
    //            for (i = 0; i < b; i++)
    //                WriteLine($"{a}*{b} = {total}");
    //            break;
    //        case '/':
    //            break;

    //    }
    //}
}

#endif

#if TASK_6

void CodeAscii()
{
    WriteLine("Введите предложения через точку");
    string text_6 = ReadLine();
    WriteLine();
    //WriteLine(text);
    char[] chars = text_6.ToCharArray();
    int k = 0;
    for (int i = 0; i < chars.Length-1; i++)
    {
        if (i == 0)
        {
            chars[i] = Char.ToUpper(chars[i]);
        }
        if (chars[i] == '.' || chars[i]=='?' || chars[i]=='!')
        {
           k = i + 2;
            if (k < chars.Length-1) { chars[k] = Char.ToUpper(chars[k]); }
           
        }
    }
    string TextEdit = new String(chars);

    //foreach (char c in chars) { Write(c); }
    WriteLine(TextEdit);
}
#endif

#if TASK_7
void BadWords()
{
    string text_7 = "To be, or not to be, that is the question,\r\nWhether 'tis nobler in the mind to suffer\r\nThe slings and arrows of outrageous fortune,\r\nOr to take arms against a sea of troubles,\r\nAnd by opposing end them? To die: to sleep;\r\nNo more; and by a sleep to say we end\r\nThe heart-ache and the thousand natural shocks\r\nThat flesh is heir to, 'tis a consummation\r\nDevoutly to be wish'd. To die, to sleep";
    WriteLine(text_7);  
    WriteLine();
    //string[] s = {"Сука", "сука", "СУКА", "die", "Die", "DIE" };
    string CorrectString = text_7.Replace("сука", "***").Replace("Сука","***").Replace("die" , "***").Replace("Die","***");

    WriteLine("Отредактированная строка текста");
    WriteLine();
    WriteLine(CorrectString);
    char temp = '*';
    var amount = CorrectString.Count(x => x == temp);
    WriteLine();
    WriteLine("Статистика: " + amount/3 + " запикано");
} 
#endif

string[] menuItem = new string[] { "Программа - 1 \"Работа с Одномерным и Двумерным массивами\"", "Программа - 2 \"Сумма элементов в промежутке Min-Max\"", "Программа - 3 \"Шифр Цезаря\"", "Программа - 4 \"Операции умножения на матрицы число, сложение матриц, произведение матриц\"", "Программа - 5 \"Арифметическое выражение\"", "Программа - 6 \"Большая буква после точки\"", "Программа - 7 \"Запикивание плохих слов\"", "Программа - 8 \"Выход из программы\"" };

foreach (string menu in menuItem)
{
    WriteLine(menu);
}
WriteLine();
WriteLine("Выберите программу с которой хотите работать");
Write(">> ");
String str = ReadLine();
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
        int maxArray2D_2 = MaxArray2D_2();
        int minArray2D_2 = MinArray2D_2();
        Coordinates(maxArray2D_2, minArray2D_2);      
        break;
     case "3":
        WriteLine("3");
        break;
     case "4":
        Clear();
        WriteLine("Заполнение матрицы 1");
        FillingMatrixArray2D_4(Array1_2D_4);
        WriteLine("Заполнение матрицы 2");
        FillingMatrixArray2D_4(Array2_2D_4);
        WriteLine();
        WriteLine("Вывод матрицы 1");
        PrintMatrixArray2D_4(Array1_2D_4);
        WriteLine("Вывод матрицы 2");
        PrintMatrixArray2D_4(Array2_2D_4);
        WriteLine("Умножение матрицы на число");
        int[,] matrixM = MatrixMultiplicationByNumber(Array2_2D_4, 5);
        PrintMatrixArray2D_4(matrixM);
        WriteLine("Сложение матриц");
        int[,] matrixS = SumArr2D_4(Array1_2D_4, Array2_2D_4);
        PrintMatrixArray2D_4(matrixS);
        WriteLine("Произведение матриц");
        int[,] matrixC = MatrixMultiplication(Array1_2D_4, Array2_2D_4);
        PrintMatrixArray2D_4(matrixC);
        break;
     case "5":
        WriteLine("5");
        MathPlusMinus();
        break;
     case "6":
        Clear();
        CodeAscii();
        break;
     case "7":
        Clear();
        BadWords();
        break;
     case "8":
        break;
     default:
        WriteLine("Выбран неверный пункт меню");
        break;

    }