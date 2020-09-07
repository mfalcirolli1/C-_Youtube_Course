using System;

public class Aviao {

    public String empresa;
    public String modelo;

    public Aviao() {

        System.Console.WriteLine("Decolar");
    }

    public Aviao(int x, int y) {
        Console.WriteLine("Soma: " + (x+y));
    }

}

// public class DecolarAviao {

//     public static void Main(string[] args)
//     {
//         Aviao Gol = new Aviao();
//         Aviao Boeng = new Aviao(10, 15);

//         Gol.modelo = "747";
//         Boeng.empresa = "American Airlanes";

//         Console.WriteLine(Gol.modelo);
//         Console.WriteLine(Boeng.empresa);
//     }
// }

public class Jatinho : Aviao {

    public double altura;
    public int valor;

    public void mostrarInfo(){

        Console.WriteLine("Altura: " + altura + " Valor: " + valor);

    }
}

public class DecolarJatinho{

    public static void Main(string[] args)
    {
        
        Jatinho Neymar = new Jatinho();
        Neymar.empresa = "Latam";
        Neymar.modelo = "747";
        Neymar.altura = 1.8;

        Neymar.mostrarInfo();

    }
}
