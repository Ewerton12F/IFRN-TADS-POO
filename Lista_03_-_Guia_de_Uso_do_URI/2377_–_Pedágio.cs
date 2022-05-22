using System;

class MainClass {
    public static void Main (string[] args) {
        string[] val1 = Console.ReadLine().Split(' ');
        string[] val2 = Console.ReadLine().Split(' ');

        int L = int.Parse(val1[0]); // comprimento da estrada
        int D = int.Parse(val1[1]); // distância entre pedágios

        int K = int.Parse(val2[0]); // custo por quilômetro
        int P = int.Parse(val2[1]); // valor de cada pedágio

        int qtd_ped = L / D;
        int custo_km = L * K;
        int custo_ped = qtd_ped * P;

        int tot = custo_km + custo_ped;

        Console.WriteLine($"{tot}");
    }
}

// mcs -out:Main.exe 'Lista_03_-_Guia_de_Uso_do_URI/2377_–_Pedágio.cs' ; mono Main.exe