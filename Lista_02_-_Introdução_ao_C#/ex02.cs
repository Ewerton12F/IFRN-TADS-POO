using System;

class MainClass {
    public static void Main (string[] args) {
        Console.WriteLine("Digite seu nome completo:");
        string nome = Console.ReadLine();
        string[] primeiro = nome.Split(' ');
        Console.WriteLine($"Bem-vindo ao C#, {primeiro[0]}");
    }
}

// mcs -out:Main.exe 'Lista_02_-_Introdução_ao_C#/ex02.cs' ; mono Main.exe