using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Работа с массивами размерных типов.
Программа, в которой в метод Main в качестве аргумента будет передаваться имя текстового файла. 
Содержимое текстового файла будет считываться в массив символов, 
а дальше будут производиться итерации по всему массиву для подсчета количества гласных и согласных. 
В итоге, на консоль будет выводиться информация об общем количестве символов, гласных, согласных и строк.
 */
namespace FileDetails
{
    class FileDetails
    {
        public static void Summarize(char[] contents)
        {
            int glas = 0, sogl = 0, lines = 0;
            foreach (char current in contents)
            {
                if (Char.IsLetter(current))
                {
                    if ("AEIOUaeiou".IndexOf(current) != -1)
                    {
                        glas++;
                    }
                    else
                    {
                        sogl++;
                    }
                }else if(current == '\n')
                {
                    lines++;
                }
            }
            Console.WriteLine("Total number of characters: {0}", contents.Length);
            Console.WriteLine("Total number of vowels: {0}", glas);
            Console.WriteLine("Total number of consonants: {0}", sogl);
            Console.WriteLine("Total number of lines: {0}", lines);
        }
        public static void Main(string[] args)
        {
            /*
            //Передать в метод Main в качестве параметра имя текстового файла
            Console.WriteLine(args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            */
            string fileName = args[0];

            //Считайте содержимое текстового файла в массив
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            char[] contents = reader.ReadToEnd().ToCharArray();
            
            /*
            //check result
            foreach (char ch in contents)
            {
                Console.Write(ch);
            }
            */
            stream.Close();
            reader.Close();

            //Систематизируйте и резюмируйте информацию о содержимом файла
            Summarize(contents);
           
        }
    }
}
