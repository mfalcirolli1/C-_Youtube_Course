// Array - Vetor

using System;

class Aula17{

    static void Main(){
        
        // int n1 , n2, n3, n4, n5;

        int[] n = new int[5];
        n[0] = 10;
        n[1] = 100;
        n[2] = 1000;
        n[3] = 10000;
        n[4] = 100000;
        Console.WriteLine(n[0]);

        int[] num = new int[3]{55, 77, 99};
        Console.WriteLine(num[2]);

        int[] nume = {55, 77, 99};

        string[] veiculos = {"Carro", "Moto", "Barco"};
        Console.WriteLine(veiculos[0]);
    }
}