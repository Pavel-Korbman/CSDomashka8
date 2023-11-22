// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): 
// Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB. 
// Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, 
// то выводится сообщение "It is impossible to multiply." 
// В противном случае, вызывается метод MatrixMultiplication 
// для умножения матриц, и результат выводится с помощью метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): 
// Метод для умножения двух матриц matrixA и matrixB. 
// Метод возвращает новую матрицу, 
// которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

int[,] matrixA = new int[,]
{
    {2, 4},
    {1, 3},
    {5, 6}
};

int[,] matrixB = new int[,]
{
    {5, 6},
    {7, 8}
};

// // Проверка возможности умножения 2-х мерного массивов
void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
        Console.WriteLine("It is impossible to multiply.");
    else
    {
    //    int[,] res =MatrixMultiplication(matrixA, matrixB);
       PrintMatrix(MatrixMultiplication(matrixA, matrixB));
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{

int[,] result = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
              result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return result;
}


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


MultiplyIfPossible(matrixA, matrixB);
// PrintMatrix(MatrixMultiplication(matrixA, matrixB));