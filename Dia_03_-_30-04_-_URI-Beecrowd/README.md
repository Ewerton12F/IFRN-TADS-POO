# Guia de Uso do URI (beecrowd)

## Objetivos

- Conhecer o site URI Online Judge
- Registrar-se e resolver problemas no URI
- Entender os diferentes resultados da submissão de problemas

## URI Online Judge

- O URI Online Judge é site voltado para a prática de programação e o compartilhamento de conhecimento em algoritmos e linguagens de programação.
    - Repositório de Problemas
    - Avaliação de Soluções (Submissões)
    - Fórum de Discussão
    - Torneios e Competições de Programação
- Registro no Site
• [https://www.beecrowd.com.br/judge/pt/register](https://www.beecrowd.com.br/judge/pt/register)

## URI – Configurações

- Menu Perfil – Configurações
    - Configurações de Linguagem do Site e Linguagem de Programação

## URI – Problemas

- Menu Problemas: Os problemas estão divididos em 9 categorias
    - Iniciante, Ad-hoc, Strings, Estruturas, Matemática, Paradigmas, Grafos, Geometria Computacional e SQL

## URI – Iniciante

- Problemas básicos para quem está iniciando na programação
    - Selecione o problema 1001 para resolver

## URI 1001 – Página do Problema

- A página do problema apresenta sua descrição e área de código

## URI 1001 – Extremamente Básico

- Analise a descrição, a entrada e a saída de dados do problema.

## URI 1001 – Entrada e Saída

- Exemplos de valores de entrada e saída são também fornecidos
    - É importante que sua solução teste todos esses valores
    - Outros valores de entradas são testados pelo Juiz OnLine
    - A saída deve corresponder exatamente ao solicitado no problema: valores
    e formatação

## URI 1001 – Solução

- Solução em C#
    
    ```csharp
    using System;
    class MainClass {
        public static void Main (string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = a + b;
            Console.WriteLine($"X = {x}");
        }
    }
    ```
    

## URI 1001 – Submissão

- Na área de código, ao lado do problema, é feita a submissão

## URI – Submissões

- No menu Submissões Todas, verifique o resultado de sua resposta para o problema

## Presentation Error

- Erro de Apresentação
    - A solução possui espaços ou caracteres Enter a mais ou a menos, ou ainda diferenças entre caracteres maiúsculos e minúsculos.

## Wrong Answer

- Resposta Errada
    - A solução não obteve a saída esperada para o problema

## Runtime Error

- Erro de Execução
    - A solução provocou um erro durante a execução do programa

## Compilation Error

- Erro de Compilação
    - A solução provocou um erro durante a compilação do programa. Erro de sintaxe.

## Time Limit Exceeded

- Limite de Tempo Excedido
    - A solução não obteve a saída no tempo proposto para o problema.
    - Nesse caso, uma solução mais rápida para o problema é necessária.

## URI 1010 – Cálculo Simples

- Em alguns problemas, a entrada tem vários valores por linha.
- No C#, é necessário ler a linha inteira e depois separar os valores.

## URI 1010 – Entrada e Saída

- Cada linha da entrada possui dois valores inteiros e um real
- Nestes casos, é necessário usar o método Split (de String) para separar os valores de cada linha em três partes (textos) e depois converter para número inteiro ou real

## URI 1010 – Solução

```csharp
using System;

class MainClass{
    public static void Main (string[] args) {
        string[] a = Console.ReadLine().Split(' ');
        string[] b = Console.ReadLine().Split(' ');
        
        int c1 = int.Parse(a[0]); 
        int n1 = int.Parse(a[1]);

        double v1 = double.Parse(a[2]);

        int c2 = int.Parse(b[0]);
        int n2 = int.Parse(b[1]);

        double v2 = double.Parse(b[2]);
        double vp = n1 * v1 + n2 * v2;
        
        Console.WriteLine($"VALOR A PAGAR: R$ {vp:0.00}");
    }
}
```

## Referências

- URI OnLine Judge - Beecrowd
    - [https://www.beecrowd.com.br/judge/pt/login](https://www.beecrowd.com.br/judge/pt/login)
- Problema 1001 – Extremamente Básico
    - [https://www.beecrowd.com.br/judge/pt/problems/view/1001](https://www.beecrowd.com.br/judge/pt/problems/view/1001)
- Problema 1010 – Cálculo Simples
    - [https://www.beecrowd.com.br/judge/pt/problems/view/1010](https://www.beecrowd.com.br/judge/pt/problems/view/1010)
- String – Método Split
    - [https://docs.microsoft.com/pt-br/dotnet/api/system.string.split](https://docs.microsoft.com/pt-br/dotnet/api/system.string.split)