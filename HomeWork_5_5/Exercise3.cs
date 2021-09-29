using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_5
{
    class Exercise3
    { 
        /// <summary>
        /// Удалим двойное и более повторение символа
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string DellDubleCharInText (string text)
        {   
            string str = text.ToLower();
            string reText = str[0].ToString();
            char repit = str[0];

            for(int i= 1; i< str.Length; i++)
            {
                if (str[i] != repit)
                {
                    repit = str[i];
                    reText += str[i].ToString();
                }
            }
            return reText;
        }
    }
}
