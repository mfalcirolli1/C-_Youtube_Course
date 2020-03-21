// Go To Label

using System;

class Aula16{

    static void Main(){
        
        int tempo;
        char escolha;
        float tempoconvert;
        char choice;

        inicio: // Label
        Console.Clear();

        Console.WriteLine("SP a RS");
        Console.WriteLine("Escolha o Transporte: \n[a] Avião \n[c] Carro \n[o] Ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){    // Compara o valor da variável indicada [escolha] com constantes definadas [a,A,c,C,o,O]
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }

        tempoconvert = tempo / 60;
        
        if(tempo < 0){
            Console.WriteLine("Transporte inexistente. Tente novamente.");
        }
        else{
            Console.WriteLine("Para o transporte escolhido o tempo de viagem é: {0} minutos | {1} horas", tempo, tempoconvert);
        }

        choicetime:

        Console.WriteLine("Deseja realizar uma nova consulta? [Yy/Nn] ");
        choice = char.Parse(Console.ReadLine());

        if(choice == 'Y' || choice == 'y') {
            goto inicio;
        }
        else if (choice == 'N' || choice == 'n') {
            Console.Clear();
            Console.WriteLine("Fim do programa.");
        }
        else {
            goto choicetime;
        }
    }
}