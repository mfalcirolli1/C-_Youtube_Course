// Array - Matriz

using System;

class Aula18{

    static void Main(){

        int[,] n = new int[3, 5];  // [linhas , colunas]
        int[,] num = new int[2, 2]{{10, 20}, {30, 40}};

        n[0, 0] = 10;   n[0, 1] = 11;   n[0, 2] = 20;   n[0, 3] = 22;   n[0, 4] = 30;
        n[1, 0] = 100;  n[1, 1] = 111;  n[1, 2] = 200;  n[1, 3] = 222;  n[1, 4] = 300;
        n[2, 0] = 1000; n[2, 1] = 1111; n[2, 2] = 2000; n[2, 3] = 2222; n[2, 4] = 3000;

        Console.WriteLine(n[2, 3]);
        Console.WriteLine(num[1, 0]);
    }
}