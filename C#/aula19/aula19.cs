// Loop FOR

using System;


class Aula19{


    static void Main(){
        
        int[] numero = new int[11];

        for(int num = 0; num <= 10; num += 1){

            Console.WriteLine("Valor: {0}", num);

        }

        for(int i = 0; i < numero.Length ; i += 1){

            numero[i] = i;
            Console.WriteLine("Na posição {0} se encontra o valor {1}.", i, numero[i]);

        }

    }
}