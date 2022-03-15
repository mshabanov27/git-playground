using System;

namespace NiceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm doing some very important stuff!");

<<<<<<< HEAD
            var fileReader = new TextFileReader("../../../input.txt");
=======
            var fileReader = new EmptyFileReader();
>>>>>>> origin/another-merge-conflict-branch
            
            var stuff = new ImportantStuff();
            var result = stuff.DoWhatNeedsToBeDone(fileReader);
            
            Console.WriteLine($"Result is {result}");
            
            // Wait for input
            Console.ReadLine();
        }
    }
}