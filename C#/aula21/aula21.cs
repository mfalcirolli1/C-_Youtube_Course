// DO WHILE - Executa determinados comandos antes do teste lógico pelo menos 1 vez.

using System;

class Aula21{

    static void Main(){
        
        int num = 5;
        string senha = "123";
        string senhauser;
        int tentativas = 0;

        while(num < 5){
            Console.WriteLine("Teste 1");

        }


        do{

            System.Threading.Thread.Sleep(2500);
            Console.Clear();
            Console.Write("Digite a sua senha (3 tentativas possíveis): ");
            senhauser = Console.ReadLine();
            tentativas += 1;

            if(senha == senhauser){
                Console.WriteLine("Acesso liberado.");
            }
            else{
                Console.WriteLine("Acesso negado!");
            }

            if(tentativas == 2 & senha != senhauser){
                Console.WriteLine("Você só possui mais uma tentativa.");
            }
            else if(tentativas == 3 & senha != senhauser){
                Console.WriteLine("3 tentativas realizados sem sucesso. Conta bloqueada.");
                break;
            }


        }while(senha != senhauser);

    }
}