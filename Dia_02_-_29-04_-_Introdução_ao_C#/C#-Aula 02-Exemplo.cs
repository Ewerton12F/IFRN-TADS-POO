using System;

class MainClass {
    public static void Main (string[] args) {
        double b, h, a;
        Console.WriteLine("Digite a base do triangulo: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura do triangulo: ");
        h = double.Parse(Console.ReadLine());
        a = b * h / 2;
        Console.WriteLine($"Área = {a:0.00}");
    }
}

// mcs -out:Main.exe 'Dia_02_-_29-04_-_Introdução_ao_C#/C#-Aula 02-Exemplo.cs' ; mono Main.exe