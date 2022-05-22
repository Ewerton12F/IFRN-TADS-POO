using System;

class MainClass {
    public static void Main (string[] args) {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"{n/100} nota(s) de R$ 100,00");
        Console.WriteLine($"{(n%100) / 50} nota(s) de R$ 50,00");
        Console.WriteLine($"{((n%100) % 50) / 20} nota(s) de R$ 20,00");
        Console.WriteLine($"{(((n%100) % 50) % 20) / 10} nota(s) de R$ 10,00");
        Console.WriteLine($"{((((n%100) % 50) % 20) % 10) / 5} nota(s) de R$ 5,00");
        Console.WriteLine($"{(((((n%100) % 50) % 20) % 10) % 5) / 2} nota(s) de R$ 2,00");
        Console.WriteLine($"{((((((n%100) % 50) % 20) % 10) % 5) % 2) / 1} nota(s) de R$ 1,00");
    }
}

// mcs -out:Main.exe 'Lista_03_-_Guia_de_Uso_do_URI/1018_–_Cedulas.cs' ; mono Main.exe