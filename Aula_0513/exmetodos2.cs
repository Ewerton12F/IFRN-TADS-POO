using System;

class Program {
    public static void Main() {
        int x = Matematica.MenorValor(4, 5);
        Console.WriteLine(x);
        Console.WriteLine(Matematica.MenorValor(8, 1, 5));
        int[] w = {10, 5, 6, 3, 7};
        Console.WriteLine(Matematica.MenorValor(w));
        Console.WriteLine(Matematica.MenorValor(8.1, 5.4));
        Matematica.MostrarRaizQuadrada(49);
        Array.Sort(w);
        foreach(int i in w)
            Console.WriteLine(i);
        Console.WriteLine(Matematica.ValorPI());
        int a =10;
        int b = 20;
        int c = 15;
        Cosole.WriteLine($"a = {a}, b = {b}");
        Matematica.TrocarValor(ref a, ref b);
        Cosole.WriteLine($"a = {a}, b = {b}");
        int d, e;
        Matematica.MenorMaiorValor(a, b, c, out, d, out e);
        Cosole.WriteLine($"Menor = {d}, b = {e}");
        
    }
}
class Matematica{
    public static int MenorMaiorValor(int a, int b, int c, out int menor, out int maior) {
        menor = a;
        if (b < menor) menor = b;
        if (c < menor) menor = c;
        maior = a;
        if (b > maior) maior = b;
        if (c > maior) maior = c;
    }
    public static void TrocarValor(ref int x, ref int y) {
        int aux = x;
        x = y;
        y = aux;
    }
    public static void MostrarRaizQuadrada(double x) {
        Console>WriteLine(Math.Sqrt(x));
    }
    public static int MenorValor(double a, double b, double c) {
        int menor = a;
        if (b < menor) menor = b;
        if (c < menor) menor = c;
        return menor;
    }
    public static int MenorValor(int a, int b) {
        int menor = a;
        if (b < menor) menor = b;
        return menor;
    }

    public static int MenorValor(int a, int b, int c) {
        int menor = a;
        if (b < menor) menor = b;
        if (c < menor) menor = c;
        return menor;
    }

    public static int MenorValor([] v) {
        int menor = v[0];
        foreach(int i in v)
            if (i < menor) menor = i;
        return menor;
    }
    public static double ValorPI() {
        
    }

}