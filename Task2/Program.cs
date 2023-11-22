// umOfRow(int[,] matrix, int row): 
// Метод для вычисления суммы элементов в заданной строке row матрицы matrix. 
// Метод принимает двумерный массив целых чисел matrix и номер строки row, 
// а возвращает целое число - сумму элементов в данной строке.

// MinimumSumRow(int[,] matrix): 
// Метод для определения строки с наименьшей суммой элементов. 
// Метод принимает двумерный массив целых чисел matrix 
// и возвращает массив из двух элементов: номер строки 
// с наименьшей суммой (нумерация начинается с 0) и саму сумму.

// Аргументы, передаваемые в метод/функцию:
// '9, 1, 7; 1, 2, 3; 4, 5, 6'

// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6   

// Сумма наименьшей строки (строка 2): 6
// Сумма элементов в строке 2: 6

// Ввод массива:
int[,] matrix = new int[,]
{
    {9, 1, 7},
    {1, 2, 3},
    {4, 5, 6}
};
// // Печать 2-мерного массива
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int SumOfRow(int[,] matrix, int row)
    {
    int result = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    result = result + matrix[row, j];   
    }
    return result;
    }

int[] MinimumSumRow(int[,] matrix)
    {
    int [] result = new int[2]{0,SumOfRow(matrix, 0)};
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
     if (SumOfRow(matrix, i)< result[1]) 
     {
       result[1]= SumOfRow(matrix, i);
       result[0]= i;
     }   
    }
    return result;
    }



PrintMatrix(matrix);
int [] res = MinimumSumRow(matrix);
Console.WriteLine($"Номер мин строки: {res[0]+1}");
Console.WriteLine($"Сумма мин строки: {res[1]}");