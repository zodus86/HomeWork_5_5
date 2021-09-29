using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_5
{
    class Exercise4
    {
        /// <summary>
        /// Прогрессия ли или нет
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
    public static bool Progression(params int[] array)
        {
            if (ProgressionArifmetic(array) | ProgressionGeometric(array))
                return true;

            return false;
        }

        static bool ProgressionArifmetic (params int[] array)
        {
            int x = array[1] - array[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] + x != array[i + 1])
                    return false;
            }
            Console.Write("+ Арифметическая ");
            return true;
        }

        static bool ProgressionGeometric(params int[] array)
        {
            int d = array[1] / array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] * d != array [i + 1])
                    return false;
            }
            Console.Write("* Геометрическая ");
            return true;
        }
    }
}
