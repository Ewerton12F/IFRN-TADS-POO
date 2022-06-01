# I. Exercícios de Programação Básica. Implementar programas em C# para resolver os seguintes problemas do site URI Online Judge:

[1012 – Área](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_04_-_Guia_de_Uso_do_GitHub/1012_%E2%80%93_%C3%81rea.cs)

```csharp
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
```

[1017 – Gasto de Combustível](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_04_-_Guia_de_Uso_do_GitHub/1017_%E2%80%93_Gasto_de_Combust%C3%ADvel.cs)

```csharp
using System;

class MainClass {
    public static void Main (string[] args) {
        double time = double.Parse(Console.ReadLine());
        double speed = double.Parse(Console.ReadLine());

        double liters = time * (speed / 12);

        Console.WriteLine($"{liters:0.000}");
    }
}
```

# II. Definição de repositório no GitHub

Crie um repositório no GitHub para armazenar todas as listas de exercícios realizadas na disciplina.

O repositório deve ter uma pasta para cada lista de exercícios e, dentro de cada pasta, os arquivos referentes aos problemas resolvidos. Nas pastas, os arquivos devem ser nomeados de acordo com o número da questão da lista (como mostrado para a Lista 01) ou com o número do problema do site URI (como mostrado para a Lista 04).

Faça a clonagem do repositório no [repl.it](http://repl.it/).

Envie o endereço do seu repositório como comentário particular da tarefa.