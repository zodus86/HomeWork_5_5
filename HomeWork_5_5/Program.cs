using System;

namespace HomeWork_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание1
            Console.WriteLine("Задание 1 \nЭто исходная Матрица1");
            int[,] matrix1 = CreateMatrix(5, 5);
            PrintMatrix(matrix1);
           
            Console.WriteLine("\nЭто исходная Матрица2");
            int[,] matrix2 = CreateMatrix(5, 5);
            PrintMatrix(matrix2);

            Console.WriteLine("\n 1.1 Умножение на число (matrix1 * 5)");
            int [,] matrix_1_1 = Exercise1.MatrixMultiplication(matrix1, 5);
            PrintMatrix(matrix_1_1);

            Console.WriteLine("\n 1.2 Сумма двух матрицы matrix1 + matrix2");
            int [,] matrix_1_2 = Exercise1.SummMatrix(matrix1, matrix2);
            PrintMatrix(matrix_1_2);

            Console.WriteLine("\n 1.3 Разность двух матриц matrix1 - matrix2");
            int[,] matrix_1_3 = Exercise1.Minus(matrix1, matrix2);
            PrintMatrix(matrix_1_3);

            Console.WriteLine("\n 1.4 Произведение двух матриц matrix1 * matrix2");
            int[,] matrix_1_4 = Exercise1.MultiMatrix(matrix1, matrix2);
            PrintMatrix(matrix_1_4);

            #endregion

            #region Задание 2
            String text = "Очень объемный текст на много много страниц " +
              "созданый специально для задании и эксперементов и опытов и эксперементов";

            Console.WriteLine($"\n3адания 2\nИсходный текст \n{text}");

            Console.WriteLine("Задание 2_1 ");
            Exercise2.MinSizeWord(text);
            
            Console.WriteLine("Задание 2_2 ");
            Exercise2.MaxSizeWords(text);

            #endregion

            #region Задание3

            text = "ПППОООГГГООООДДДААА    Ххххоооорррооошшшиий деееннннь ";
            Console.WriteLine("\n\nЗадание 3");
            Console.WriteLine(Exercise3.DellDubleCharInText(text));
            #endregion

            #region Задание 4
            Console.WriteLine("\nЗадание 4");
            int[] progression1 = { 1,2,3,4,5,6,7,8,9,10};

            int[] progression2 = { 1, 2, 4, 8, 16, 32 };

            int[] progression3 = { 2, 4, 16, 2 , 8 , 4, 16 };

            Console.WriteLine($"Определим является ли {PrintArray(progression1)} прогрессией или нет.");
            Console.WriteLine($" Результат = {Exercise4.Progression(progression1)}");

            Console.WriteLine($"Определим является ли {PrintArray(progression2)} прогрессией или нет.");
            Console.WriteLine($" Результат = {Exercise4.Progression(progression2)}");

            Console.WriteLine($"Определим является ли {PrintArray(progression3)} прогрессией или нет.");
            Console.WriteLine($" Результат = {Exercise4.Progression(progression3)}");

            #endregion


            #region Задание 5

            Console.WriteLine("\nФункция Аккермана");
            Console.WriteLine($" От числе m = 2, n = 4 . Результат = {Exercise5.Akkerman (2, 4)}");

            #endregion

        }
        
        private static string PrintArray(int[] array)
        {
            string str = "";

            foreach (var i in array)
                str += i + " ";

            return str;
        }

        /// <summary>
        /// Вывести в консоль двумерный массив
        /// </summary>
        /// <param name="matrix"></param>
        private static void PrintMatrix (int [,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(String.Format("{0,6}", matrix[i, j]));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Создаем двумерный массив
        /// </summary>
        /// <param name="m">Вертикальный объем</param>
        /// <param name="n">Горизонтальный объем</param>
        /// <returns></returns>
        private static int[,] CreateMatrix(int m, int n)
        {
            int[,] matrix = new int[m, n];

            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(1, 100);
                }
            }

            return matrix;
        }
       
    }
}
