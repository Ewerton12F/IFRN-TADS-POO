using System;

class MainClass {
    public static void Main (string[] args) {
        string[] p1 = Console.ReadLine().Split(" ");
        string[] p2 = Console.ReadLine().Split(" ");

        double x1 = double.Parse(p1[0]);
        double y1 = double.Parse(p1[1]);

        double x2 = double.Parse(p2[0]);
        double y2 = double.Parse(p2[1]);

        double res1 = Math.Pow((x2 - x1), 2); 
        double res2 = Math.Pow((y2 - y1), 2); 

        double distance = Math.Sqrt(res1 + res2);

        Console.WriteLine($"{distance:0.0000}");
    }
}

// mcs -out:Main.exe 'Lista_03_-_Guia_de_Uso_do_URI/1015_–_Distância_Entre_Dois_Pontos.cs' ; mono Main.exe