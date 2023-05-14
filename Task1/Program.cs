using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\data";
            string searchPattern = "*.txt";
            //string[] dirs = Directory.GetFiles(path, searchPattern);

            var files = GetFilesFromFolder(path, searchPattern);

            var wordsInFiles = 0;

            foreach (var file in files)
            {
                var readedText = ReadTextInFile(file);
                var countedWords = CountWordsInText(readedText);
                wordsInFiles = wordsInFiles + countedWords;
            }

            Console.WriteLine("Counted words in all files in folder: " + wordsInFiles);
            Console.ReadKey();
        }

        static string[] GetFilesFromFolder(string path, string pattern)
        {
            return Directory.GetFiles(path, pattern);
        }

        static string ReadTextInFile(string path)
        {
            return File.ReadAllText(path);
        }

        static int CountWordsInText(string text)
        {
            var splittedText = text.Split(' ');
            return splittedText.Length;
        }
    }
}
