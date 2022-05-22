# I. Exercícios de Programação Básica. Implementar programas em C# para resolver os seguintes problemas do site URI Online Judge:

[1009 – Salário com Bônus](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_03_-_Guia_de_Uso_do_URI/1009_-_Salario_com_Bonus.cs)

```csharp
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
```

[1013 – O Maior](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_03_-_Guia_de_Uso_do_URI/1013_%E2%80%93_O_Maior.cs)

```csharp
using System;

class MainClass {
    public static void Main (string[] args) {
        string[] val = Console.ReadLine().Split(' ');

        int a = int.Parse(val[0]);
        int b = int.Parse(val[1]);
        int c = int.Parse(val[2]);

        int maiorAB = (a + b + Math.Abs(a - b)) / 2;
        int maiorCmaiorAB = (c + maiorAB + Math.Abs(c - maiorAB)) / 2;

        Console.WriteLine($"{maiorCmaiorAB} eh o maior");
    }
}

// mcs -out:Main.exe 'Lista_03_-_Guia_de_Uso_do_URI/1013_–_O_Maior.cs' ; mono Main.exe
```

[1014 – Consumo](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_03_-_Guia_de_Uso_do_URI/1014_-_Consumo.cs)

```csharp
using System;

class MainClass {
    public static void Main (string[] args) {
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        
        double consumption = x / y;

        Console.WriteLine($"{consumption:0.000} km/l");
    }
}

// mcs -out:Main.exe 'Lista_03_-_Guia_de_Uso_do_URI/1014_-_Consumo.cs' ; mono Main.exe
```

[1015 – Distância Entre Dois Pontos](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_03_-_Guia_de_Uso_do_URI/1015_%E2%80%93_Dist%C3%A2ncia_Entre_Dois_Pontos.cs)

```csharp
using System;

class MainClass {
    public static void Main (string[] args) {
        string[] p1 = Console.ReadLine().Split(' ');
        string[] p2 = Console.ReadLine().Split(' ');

        double x1 = double.Parse(p1[0]);
        double y1 = double.Parse(p1[1]);

        double x2 = double.Parse(p2[0]);
        double y2 = double.Parse(p2[1]);

        double res1 = Math.Pow((x2 - x1), 2); 
        double res2 = Math.Pow((y2 - y1), 2); 

        double distance = Math.Sqrt(res1 + res2);

        Console.WriteLine($"{distance:0.0000}");
    }
}

// mcs -out:Main.exe 'Lista_03_-_Guia_de_Uso_do_URI/1015_–_Distância_Entre_Dois_Pontos.cs' ; mono Main.exe
```

[1018 – Cédulas](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_03_-_Guia_de_Uso_do_URI/1018_%E2%80%93_Cedulas.cs)

```csharp
using System;

class MainClass {
    public static void Main (string[] args) {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"{n/100} nota(s) de R$ 100,00");
        Console.WriteLine($"{(n%100) / 50} nota(s) de R$ 50,00");
        Console.WriteLine($"{((n%100) % 50) / 20} nota(s) de R$ 20,00");
        Console.WriteLine($"{(((n%100) % 50) % 20) / 10} nota(s) de R$ 10,00");
        Console.WriteLine($"{((((n%100) % 50) % 20) % 10) / 5} nota(s) de R$ 5,00");
        Console.WriteLine($"{(((((n%100) % 50) % 20) % 10) % 5) / 2} nota(s) de R$ 2,00");
        Console.WriteLine($"{((((((n%100) % 50) % 20) % 10) % 5) % 2) / 1} nota(s) de R$ 1,00");
    }
}

// mcs -out:Main.exe 'Lista_03_-_Guia_de_Uso_do_URI/1018_–_Cedulas.cs' ; mono Main.exe
```

[2377 – Pedágio](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_03_-_Guia_de_Uso_do_URI/2377_%E2%80%93_Ped%C3%A1gio.cs)

```csharp
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
```