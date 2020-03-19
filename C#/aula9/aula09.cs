// Bitwise

// >> Metade       00011010 >> 26
//                 00001101 >> 13

// << Dobrar       00001010 << 10
//                 00010100 << 20

using System;

class Aula09{

    static void Main(){

        int num = 10;
        num = num >> 1;

        Console.WriteLine(num);
    }
}