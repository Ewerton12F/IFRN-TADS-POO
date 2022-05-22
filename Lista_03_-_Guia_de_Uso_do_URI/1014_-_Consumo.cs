using System;

class MainClass {
    public static void Main (string[] args) {
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        
        double consumption = x / y;

        Console.WriteLine($"{consumption:0.000} km/l");
    }
}

// mcs -out:Main.exe 'Lista_03_-_Guia_de_Uso_do_URI/1014_-_Consumo.cs' ; mono Main.exe