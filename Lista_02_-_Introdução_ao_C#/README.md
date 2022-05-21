# I. Exercícios de Programação Básica. Implementar programas em C# para:

1. Ler o primeiro nome de uma pessoa e mostrar a mensagem: “`Bem-vindo ao C#, <xxx>`”, onde `<xxx>` é o nome informado pela pessoa.
    
    ```bash
    Digite seu primeiro nome:
    Gilbert
    
    Bem-vindo ao C#, Gilbert
    ```
    
    [ex01.cs](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_02_-_Introdu%C3%A7%C3%A3o_ao_C%23/ex01.cs)
    
    ```csharp
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
    ```
    
2. Ler o nome completo de uma pessoa e mostrar a mensagem: “`Bem-vindo ao C#, <xxx>`”, onde `<xxx>` é o primeiro nome da pessoa.
    
    ```bash
    Digite seu nome completo:
    Gilbert Azevedo da Silva
    
    Bem-vindo ao C#, Gilbert
    ```
    
    [ex02.cs](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_02_-_Introdu%C3%A7%C3%A3o_ao_C%23/ex02.cs)
    
    ```csharp
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
    ```
    
3. Calcular a média parcial de uma disciplina semestral, dadas as notas dos 1º e 2º bimestres (pesos 2 e 3). Considerar as notas com valores inteiros entre zero e cem.
    
    ```bash
    Digite a nota do primeiro bimestre da disciplina:
    50
    
    Digite a nota do segundo bimestre da disciplina:
    70
    
    Média parcial = 62
    ```
    
    [ex03.cs](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_02_-_Introdu%C3%A7%C3%A3o_ao_C%23/ex03.cs)
    
    ```csharp
    using System;
    
    class MainClass {
        public static void Main (string[] args) {
            double b1, b2, media;
            Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
            b2 = double.Parse(Console.ReadLine());
            media = ((b1 * 2) + (b2 * 3)) / 5;
            Console.WriteLine($"Média parcial = {media:0.}");
        }
    }
    
    // mcs -out:Main.exe 'Lista_02_-_Introdução_ao_C#/ex03.cs' ; mono Main.exe
    ```
    
4. Calcular área, perímetro e diagonal de um retângulo, dados sua base e sua altura. Considerar que os valores podem ser números reais. Mostrar o resultado com duas casas decimais.
    
    ```bash
    Digite a base e a altura do retângulo
    3
    4
    
    Área = 12.00 - Perímetro = 14.00 - Diagonal = 5.00
    ```
    
    [ex04.cs](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_02_-_Introdu%C3%A7%C3%A3o_ao_C%23/ex04.cs)
    
    ```csharp
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
    ```
    
5. Calcular a distância, em quilômetros, percorrida pela luz em um intervalo de tempo no formato “HH:MM:SS”. Considerar a velocidade de luz como 300 mil km/s.
    
    ```bash
    Digite o intervalo de tempo no formato “HH:MM:SS”
    02:30:00
    
    A luz percorreu 2700000000 km nesse intervalo
    ```
    
    [ex05.cs](https://github.com/Ewerton12F/IFRN-TADS-POO/blob/master/Lista_02_-_Introdu%C3%A7%C3%A3o_ao_C%23/ex05.cs)
    
    ```csharp
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
    ```