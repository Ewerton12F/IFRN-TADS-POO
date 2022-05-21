using System;

class MainClass {
    public static void Main (string[] args) {
        Console.WriteLine("Digite o intervalo de tempo no formato \"HH:MM:SS\"");
        string tempo = Console.ReadLine();
        string[] aux = tempo.Split(':');

        double h_aux = double.Parse(aux[0]);
        double m_aux = double.Parse(aux[1]);
        double s_aux = double.Parse(aux[2]);
        
        double h = h_aux * 60 * 60;
        double m = m_aux * 60;
        double s = s_aux ;

        double kms = (h + m + s) * 300000;

        Console.WriteLine($"A luz percorreu {kms} km nesse intervalo");
    }
}

// mcs -out:Main.exe 'Lista_02_-_Introdução_ao_C#/ex05.cs' ; mono Main.exe