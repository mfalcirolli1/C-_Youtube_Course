using System;

public class OpMatematicas {

    int som; int sub; int div; int mult; double pot;


    public int soma(int numero1, int numero2) {

        som = numero1 + numero2;
        return som;
    }

    public int subtracao(int numero1, int numero2) {
        
        sub = numero1 - numero2;
        return sub;
    }

    public int multiplicacao(int numero1, int numero2) {
        
        mult = numero1 * numero2;
        return mult;
    }

   public int divisao(int numero1, int numero2) {

        if (numero1 == 0 || numero2 == 0) {
            Console.WriteLine("A divisão não pode ser feita com o número 0 (zero). Por favor, tente novamente com outro número.");
        }

        div = numero1 / numero2;
        return div;
   }

   public double potencia(int numero1, int numero2) {
        
        pot = Math.Pow(numero1, numero2);
        return pot;
    }      
    
}

public class ExecutarOpMat {

    public static void Main(string[] args)
    {

        OpMatematicas Operacoes = new OpMatematicas();
        
        Console.WriteLine(Operacoes.soma(2, 8));
        Console.WriteLine(Operacoes.subtracao(2, 8));
        Console.WriteLine(Operacoes.multiplicacao(2, 8));
        Console.WriteLine(Operacoes.divisao(0, 8));
        Console.WriteLine(Operacoes.potencia(2, 8));

    }

}