using System;
using System.Collections.Generic;


namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var LoopThis = new Looping { ConsoleLoop = Console.ReadLine() };
            var InputLetters = new List<Looping>();
            var i = 0;

            foreach (var letter in LoopThis.ConsoleLoop)
            {
                i++;
                //Console.WriteLine(i);
                for (var x = 0; x < i; x++)
                {
                    Console.Write(letter);
                }
            }

            
            

            

            //Console.WriteLine(LoopThis.ConsoleLoop);
            
            
            Console.Read();
        }
    }
}
