using System;

class Aula05{

    static void Main(){
        
        int res = 10 + 5;
        bool the = 10 > 5;

        // → + - * / // % > < >= <=  != += *= ...
        //  and = &   or = |

        bool num1 = (5 > 3) | (10 < 5);
        bool num2 = (2 > 3) & (10 < 5);

        Console.WriteLine(res);
        Console.WriteLine(the);
        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }
}