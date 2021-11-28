using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Prakt17Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("file1.txt");
            List<string> list = new List<string>();
            string[] str = { };
            while (!sr.EndOfStream)
            {
                str = sr.ReadLine().Split(' ');
            }
            if (str.Length == 0)
            {
                Console.WriteLine("Файл пуст");
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string s = str[i], com = "";
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j] != '.' && s[j] != ',' && s[j] != '!' && s[j] != '?')
                        {
                            com += s[j];
                        }
                        else { break; }
                    }
                    list.Add(com.ToUpper());
                }
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Введите слово:");
                string word = Console.ReadLine();
                if (word == "" || word == " ")
                {
                    Console.WriteLine("Введено пустое слово!");
                }
                else
                {
                    var c = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        c = list.Where(x => x == word.ToUpper()).Count();
                    }
                    Console.WriteLine("Кол-во заданных слов: " + c);
                }
            }
            sr.Close();
        }
    }
}
