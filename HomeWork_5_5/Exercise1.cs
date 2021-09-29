﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_5
{
    /// <summary>
    // Задание1
    /// </summary>
    class Exercise1
    {
        /// <summary>
        /// Умножение на число матрицы
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int [,] MatrixMultiplication (int[,] matrix , int number)
        {
            int[,] reMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < reMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < reMatrix.GetLength(1); j++)
                    reMatrix[i, j] = matrix[i, j] * number;
            }
            return reMatrix;
        }

        /// <summary>
        /// сложение двух матриц 
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static int [,] SummMatrix (int[,] matrix1 , int[,] matrix2)
        {
            if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1))
            {
                int[,] reMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
                for (int i = 0; i < reMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < reMatrix.GetLength(1); j++)
                    {
                        reMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }
                return reMatrix;
            }

            Console.WriteLine("Извините матрицы разных длин, я пока не понимаю как такие складывать");
            return null;
        }
        

      /// <summary>
        /// Разность матриц равной длины
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
            public static int [,] Minus (int [,] matrix1, int[,] matrix2)
            {
            if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1))
            {
                int[,] reMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
                for (int i = 0; i < reMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < reMatrix.GetLength(1); j++)
                    {
                        reMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                    }
                }
                return reMatrix;
            }

            Console.WriteLine("Извините матрицы разных длин, результат будет null");
            return null;
        }

        /// <summary>
        /// умножение матрицы Диагональ = вертикали разных матриц
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static int [,] MultiMatrix (int[,] matrix1 , int[,] matrix2)
        {

            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                int[,] reMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
                
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix2.GetLength(0); k++)
                        {
                            reMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
                return reMatrix;
            }
            Console.WriteLine("Не умножаются ошибка! Верну null");
            return null;
            
        } 






    }
}
