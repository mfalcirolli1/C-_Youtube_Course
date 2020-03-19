// Enumeradores

using System;

class Aula10{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main(){

        DiasSemana ds = DiasSemana.Domingo;
        DiasSemana dss = (DiasSemana)3;
        int dsss = (int)DiasSemana.Sexta;
        
        Console.WriteLine("{0}, {1}, {2}", ds, dss, dsss);
    }
}