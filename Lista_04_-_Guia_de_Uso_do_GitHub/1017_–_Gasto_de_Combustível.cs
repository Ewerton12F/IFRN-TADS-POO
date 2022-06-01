using System;

class MainClass {
    public static void Main (string[] args) {
        double time = double.Parse(Console.ReadLine());
        double speed = double.Parse(Console.ReadLine());

        double liters = time * (speed / 12);

        Console.WriteLine($"{liters:0.000}");
    }
}