// Formatação de saída do console

using System;

class Aula06{
    static void Main(string[] args){

        int n1 = 10, n2 = 20, n3 = 30;

        Console.Write("n1 = \t{0} \nn2 = \t{1} \nn3 = \t{2}\n", n1,n2,n3);

        double valorc = 5.50;
        double valorv;
        double valorv2;
        double lucro = 0.1;
        string produto = "Skol";

        valorv = valorc + (valorc * lucro);
        valorv2 = valorc * 1.1;

        Console.WriteLine("Produto..........:{0,15}",produto);
        Console.WriteLine("Valor Compra.....:{0,15:c}",valorc);
        Console.WriteLine("Lucro............:{0,15:p}",lucro);
        Console.WriteLine("Valor Venda......:{0,15:c}",valorv);
    }
    
}