// Loop WHILE - Não executa comandos antes do teste lógico.

using System;


class Aula20{


    static void Main(){
        
        int[] numero = new int[11];
        int c = 0;

        while(c < 10) {
            Console.WriteLine("Teste");
            c += 1;  // Variável de controle

        }
        Console.WriteLine("Fim do Loop");

    }
}