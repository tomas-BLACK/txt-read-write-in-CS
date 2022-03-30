# txt-read-write-in-CS
How to read .txt files and write .txt files, helps you keep changes from sessions before the current one. Shown with an example code.

I used Visual Studio 2019 for this Projekt which was a Konsole Application, as it is the easiest to make and understand!
If you wish so you can donate money to me, which would definitly convince me to do more of those projects. If you have something to tell me,
for example how I can improve these Showcases aka. tutorials please tell me at: messages.tomas_black@icloud.com




Code for Copiyng easily incoming:

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
