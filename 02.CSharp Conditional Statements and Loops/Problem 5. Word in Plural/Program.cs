﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (word.EndsWith("y"))
            {
                var removed = word.Remove(word.Length - 1, 1);
                var plural = removed + "ies";
                Console.WriteLine(plural);
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                var plural = word + "es";
                Console.WriteLine(plural);
            }
            else
            {
                var plural = word + "s";
                Console.WriteLine(plural);
            }
        }
    }
}
