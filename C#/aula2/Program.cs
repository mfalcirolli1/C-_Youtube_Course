﻿using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
            if(args.GetLength(0)>0){
                Console.Write(args.GetValue(0));
            }
        }
    }
}
