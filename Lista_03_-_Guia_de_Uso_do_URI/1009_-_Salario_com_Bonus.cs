using System;

class MainClass {
    public static void Main(string[] args) {
        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double sales = double.Parse(Console.ReadLine());
        double salary_w_bonus = salary + (sales * 0.15);
        Console.WriteLine($"TOTAL = R$ {salary_w_bonus:0.00}");
    }
}

// mcs -out:Main.exe 'Lista_03_-_Guia_de_Uso_do_URI/1009_-_Salario_com_Bonus.cs' ; mono Main.exe