// Condicional IF-ELSE

using System;

class Aula12{
    static void Main(){

        int nota, nota2, nota3, nota4, nf;
        
        Console.Write("Digite a primeira nota: ");
        nota = int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        nota2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        nota3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        nota4 = int.Parse(Console.ReadLine());

        nf = nota + nota2 + nota3 + nota4;

        if(nf >= 60){
            Console.WriteLine("Nota: {0}. Aprovado.", nf);
        }
        else if (nf >= 40 & nf <= 59){
            Console.WriteLine("Nota: {0}. Recuperação.", nf);
        }
        else{
            Console.WriteLine("Nota: {0}. Reprovado.", nf);
        }
        
    }
}