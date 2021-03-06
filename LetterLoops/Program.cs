﻿using System;
using System.Collections.Generic;


namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var LoopThis = new Looping { ConsoleLoop = Console.ReadLine() };
            var i = 0;

            foreach (var letter in LoopThis.ConsoleLoop)
            {
                i++;
                //Console.WriteLine(i);
                for (var x = 0; x < i; x++)
                {
                    if (x == 0)
                    {
                        Console.Write(Char.ToUpper(letter));
                    }
                    else
                    {
                        Console.Write(letter);
                    }
                    if ((x+1) == i)
                    {
                        Console.Write("-");
                    }
                }
                
            }
            Console.Write("\b \b");
            Console.Read();
        }
    }
}
