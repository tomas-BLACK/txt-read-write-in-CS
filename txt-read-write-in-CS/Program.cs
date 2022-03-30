using System;
using System.IO;

namespace write_to_a_file
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteText();
            ReadText();

            Console.ReadKey();
        }

        public static void WriteText()
        {
            string path = "C:\\CS-Files\\file.txt";
            //string Text = "By Tomas Black.";
            string Text = @"Headline
Textline 1
Textline 2
Textline 3";
            File.WriteAllText(path, Text);
        }

        public static void ReadText()
        {
            string path = "C:\\CS-Files\\file.txt";
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}