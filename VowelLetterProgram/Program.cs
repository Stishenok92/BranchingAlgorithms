using static VowelLetterLibrary.VowelLetter;
using System;

namespace VowelLibraryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task #03. Definition symbol\n");
            Console.Write("Enter symbol: ");
            string str = Console.ReadLine();
            Console.WriteLine("Answer: " + DefinitionSymbol(str));
        }
    }
}