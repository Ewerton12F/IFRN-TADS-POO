using System;

class MainClass {
    public static void Main (string[] args) {
        string nome;
        Console.WriteLine("Digite seu primeiro nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Bem-vindo ao C#, {nome}");
    }
}

// mcs -out:Main.exe 'Lista_02_-_Introdução_ao_C#/ex01.cs' ; mono Main.exe