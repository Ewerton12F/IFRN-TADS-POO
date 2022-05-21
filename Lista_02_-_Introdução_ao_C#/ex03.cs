using System;

class MainClass {
    public static void Main (string[] args) {
        double b1, b2, media;
        Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
        b1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
        b2 = double.Parse(Console.ReadLine());
        media = ((b1 * 2) + (b2 * 3)) / 5;
        Console.WriteLine($"Média parcial = {media:0.}");
    }
}

// mcs -out:Main.exe 'Lista_02_-_Introdução_ao_C#/ex03.cs' ; mono Main.exe