using System;

class MainClass {
    public static void Main (string[] args) {
        string[] val = Console.ReadLine().Split(' ');

        double a = double.Parse(val[0]);
        double b = double.Parse(val[1]);
        double c = double.Parse(val[2]);
        double pi = 3.14159;

        double a1 = (a*c) / 2;
        double b1 = pi * Math.Pow(c, 2);
        double c1 = 0.5 * (a+b) * c;
        double d1 = Math.Pow(b, 2);
        double e1 = a * b;

        Console.WriteLine($"TRIANGULO: {a1:0.000}");
        Console.WriteLine($"CIRCULO: {b1:0.000}");
        Console.WriteLine($"TRAPEZIO: {c1:0.000}");
        Console.WriteLine($"QUADRADO: {d1:0.000}");
        Console.WriteLine($"RETANGULO: {e1:0.000}");
    }
}