// See https://aka.ms/new-console-template for more information
using static System.Console;
//Write("Введите количество элементов массива: "); //Запрос колическ=тва элементов в ручну из консоли
//int elementCount = int.Parse(ReadLine()); //Ввод колическ=тва элементов в ручну из консоли
int elementCount = 5;
int[] A = new int[elementCount];
for (int i = 0; i < elementCount; i++)
{
    Write($"Введите элемент массива под индексом {i}: ");
    A[i] = int.Parse(ReadLine());
}
WriteLine();
WriteLine("Проверка заполненности массива A");
for (int i = 0; i < elementCount; i++)
{
    Write(A[i] + "\t");
}
WriteLine();
double[,] B = new double[3,4];
Random ran = new Random();
WriteLine();
WriteLine("Проверкка заполнения двумерного массива B");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        B[i, j] = ran.NextDouble() * 5;
        Write(B[i,j] + "\t");
    }
    WriteLine();
}
var min = A.Min();
var max = A.Max();
var sum = A.Sum();
int pr = 1;
int EvenSum = 0;
for (int i = 0; i <A.Length; i++)
{ 
    pr = pr * A[i];
}

for (int i = 0; i < A.Length; i++)
{
    if (i % 2 == 0)
    {
        EvenSum = EvenSum + A[i];
    }
}
WriteLine();
WriteLine($"В массиве А минимальное число {min}, максимальное {max}");
WriteLine($"В массиве А общая сумма всех элементов {sum}");
WriteLine($"В массиве A произведение равно {pr}");
WriteLine($"В массиве A сумма четных элементов равна {EvenSum}");

int rows = B.GetLength(0);
int colunmns = B.GetLength(1);
int dimension = B.Length;
WriteLine();
WriteLine($"В массиве В строк {rows}, столбцов {colunmns}, всего элементов {dimension}");