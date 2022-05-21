using System;

class MainClass {
    public static void Main (string[] args) {
        Console.WriteLine("Digite a base e a altura do retângulo");
        double bas = double.Parse(Console.ReadLine());
        double alt = double.Parse(Console.ReadLine());
        double area = bas * alt;
        double per = (bas * 2) + (alt * 2);
        double diag = Math.Sqrt(Math.Pow(bas, 2) + Math.Pow(alt, 2));
        Console.WriteLine($"Área = {area:0.00} - Perímetro = {per:0.00} - Diagonal = {diag:0.00}");
    }
}

// mcs -out:Main.exe 'Lista_02_-_Introdução_ao_C#/ex04.cs' ; mono Main.exe