// Typecast

using System;

class Aula11{
    static void Main(){
        
        float n1 = 10.5f;
        int n2 = (int)n1;  // type cast

        int vint = 15;
        short vshort = (short)vint;

        Console.WriteLine("{0}, {1}", n2, vshort);
    }
}