// Inputs

using System;

class Aula08{

    static void Main(){

        int v1, v2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite o Primeiro Valor: ");
        v1 = int.Parse(Console.ReadLine());             // int.Parse
        
        Console.Write("Digite o Segundo Valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());       // Convert.ToInt32
        
        soma = v1 + v2;

        Console.WriteLine("Nome digitado: {0}", nome);
        Console.WriteLine("Soma de {0} + {1} é igual a {2}", v1, v2, soma);
    }
}