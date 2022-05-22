using System;

class MainClass {
    public static void Main (string[] args) {
        string[] val = Console.ReadLine().Split(' ');

        int a = int.Parse(val[0]);
        int b = int.Parse(val[1]);
        int c = int.Parse(val[2]);

        int maiorAB = (a + b + Math.Abs(a - b)) / 2;
        int maiorCmaiorAB = (c + maiorAB + Math.Abs(c - maiorAB)) / 2;

        Console.WriteLine($"{maiorCmaiorAB} eh o maior");
    }
}

// mcs -out:Main.exe 'Lista_03_-_Guia_de_Uso_do_URI/1013_–_O_Maior.cs' ; mono Main.exe