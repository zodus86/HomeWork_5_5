using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_5
{
    class Exercise2
    {
        /// <summary>
        /// найти самое короткое слово
        /// </summary>
        /// <param name="text"></param>
        public static string MinSizeWord(string text)
        {
            string[] words = SplitWords(text);
            
            if (words.Length > 1 )
            {
                int MinSize = words[0].Length;
                int indexMinimumSize = 0;
                
                for(int i = 1; i<words.Length; i++)
                {
                    if (words[i].Length < MinSize)
                    {
                        indexMinimumSize = i;
                        MinSize = words[i].Length;
                    }
                }
                Console.WriteLine($"Самое короткое словo =\"{words[indexMinimumSize]}\" ");
                return (words[indexMinimumSize]);
            }
            else
            {
                Console.WriteLine($"Самое короткое словo =\"{words[0]}\"");
                return words[0];
            }
            
        }

        /// <summary>
        /// Найти в тексте длиные слова
        /// </summary>
        /// <param name="text"></param>
        public static string[] MaxSizeWords(string text)
        {
            string[] words = SplitWords(text);
           
            if (words.Length > 1)
            {
                int MaxSize = words[0].Length;
                List<int> indexMaxSize = new List<int>();

                for (int i = 1; i < words.Length; i++)
                {
                    if (words[i].Length > MaxSize)
                    {
                        indexMaxSize.Clear();
                        indexMaxSize.Add(i);
                        MaxSize = words[i].Length;
                    }else if(words[i].Length == MaxSize)
                    {
                        indexMaxSize.Add(i);
                    }

                }
                if(indexMaxSize.Count == 1) 
                {
                    Console.WriteLine($"Самое длинное словo =\"{words[indexMaxSize[0]]}\" ");
                    return new string[] { words[0] };
                }
                else
                {
                    string[] str = new string[indexMaxSize.Count];
                    Console.WriteLine($"Самые длинные слова =");
                    for (int i =0; i< indexMaxSize.Count; i++ )
                    {
                        Console.Write($"\"{words[indexMaxSize[i]]}\" ");
                        str[i] = words[i];
                    }
                    return str;
                }

            }
            else
            {
                Console.WriteLine($"Самое длиное словo =\"{words[0]}\"");
                return new string[] { words[0] };
            }
           
        }


        private static string [] SplitWords (string text)
        {
            return text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
