using System;

class Aula03 {
    static void Main(){

        byte n1 = 10;        // 0 e 255
        int num = 0;
        char letra = 'c';
        float valor = 1.2f;
        string nome ="Matheus";

        var aux = 10;

        int num1, num2, num3;
        num1 = 5;
        num2 = 9;
        num3 = (num1 + num2) / 2;

        Console.WriteLine("Variável de valor: " + aux);
        Console.WriteLine("A Média Aritmética entre " + num1 + " e " + num2 + " é " + num3);
    }
}