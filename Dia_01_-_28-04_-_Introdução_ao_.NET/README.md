# Introdução ao .NET

## Objetivos

- Revisar os conceitos básicos de programação
- Conhecer o .NET
- Conhecer algumas características da linguagem C#
- Escrever o primeiro programa em C#

## Conceitos Básicos de Programação

- Hardware: parte física: teclado, monitor, processador, ...
- Software: parte lógica: SO, drives, aplicativos, ...
- Algoritmo
    - É uma sequência de instruções para realizar uma tarefa
- Linguagem de Programação
    - Conjunto de regras e instruções disponíveis para escrever um programa
- Código Fonte
    - É a escrita de um algoritmo em uma linguagem de programação
- Código Executável
    - É uma sequência de instruções em linguagem da máquina (binária)

## Linguagens de Programação

- Linguagem de Máquina
    - Instruções binárias (0 e 1)
- Linguagem Assembly
    - Instruções simples em Mnemônicos
- Linguagens de Alto Nível
    - Instruções complexas como: ler, escrever, calcular, ...
    - C, C++, C#, Delphi, Java, Pascal, Python, Php, VB , ...

## Plataforma .NET

- “O .NET é uma plataforma de desenvolvimento de software livre gratuita para a criação de vários tipos de aplicativos”
    - Aplicativos Web, APIs da Web
    - Aplicativos da nuvem
    - Aplicativos móveis
    - Aplicativos da Área de Trabalho do Windows
    - Jogos
    - Internet das Coisas (IoT)
    - Aprendizado de Máquina
    - Aplicativos de Console
    - Serviços do Windows
- [https://docs.microsoft.com/pt-br/dotnet/core/introduction](https://docs.microsoft.com/pt-br/dotnet/core/introduction)
- Plataforma Cruzada
    - Suporte para vários SOs: Windows, macOS, Linux, Android, iOS, tvOS, watchOS
    - Suporte para vários processadores: x64, x86, ARM32, ARM64
- Linguagens de Programação
    - C# - Linguagem Orientada a Objetos
    - F# - Linguagem Funcional
    - Visual Basic
- IDEs
    - Aplicativo para escrita e depuração de programas: Visual Studio, Visual Studio Code, Visual Studio para Mac, Codespaces do GitHub
    - Ferramentas de Linha de Comando

## Arquitetura do .NET

- Implementações do .NET
    - .NET 5 – Windows, macOS e Linux
    - .NET Framework – Windows: implementação original até versão 4.8
    - Mono – Android, macOS, iOS, tvOS e watchOS
    - UWP – IoT, Win10, Tablet, Xbox
- Principais componentes do .NET
    - Ambiente de execução – Runtime, CLR, Commom Language Runtime
        - É o software que executa uma aplicação .NET
    - Bibliotecas de classes – Framework Class Library
        - É o conjunto de classe usadas na escrita de programas para o .NET

## Programa em C#

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/e07990af-18fe-48f8-933e-b630b013c7d3/Untitled.png)

## Linguagem de Programação C#

- Linguagem desenvolvida pela Microsoft para a Plataforma .NET
- Derivada do C/C++
- Orientada a objetos: todas as variáveis são objetos
- Fortemente tipada
- Coletor de lixo
- Tratamento de erros com exceções

## Escrevendo um Código em C#

- Ambiente Integrado de Desenvolvimento
• Visual Studio - [https://visualstudio.microsoft.com/pt-br/](https://visualstudio.microsoft.com/pt-br/)
• VS Code - [https://code.visualstudio.com/](https://code.visualstudio.com/)
• MonoDevelop - [https://www.monodevelop.com/](https://www.monodevelop.com/)
- Interface de Linha de Comando
• [https://docs.microsoft.com/pt-br/dotnet/core/tools/](https://docs.microsoft.com/pt-br/dotnet/core/tools/)
- Sites de Desenvolvimento
• [https://replit.com/](https://replit.com/)

## Replit.com

- [https://replit.com/](https://replit.com/) - Várias linguagens de programação, integração com github
    - Fazer o registro para armazenar os programas desenvolvidos
    
    [https://replit.com/@EwertonFreitas/IFRN-TADS-POO#Dia_01_-_28-04_-_Introdu%C3%A7%C3%A3o_ao_.NET/bemvindo.cs](https://replit.com/@EwertonFreitas/IFRN-TADS-POO#Dia_01_-_28-04_-_Introdu%C3%A7%C3%A3o_ao_.NET/bemvindo.cs)
    
    ```bash
    > "mcs -out:Main.exe 'Dia_01_-_28-04_-_Introdução_ao_.NET/bemvindo.cs' ; mono Main.exe"
    Bem vindo ao C#
    ```
    

## Olá Mundo em Algoritmo/Pascal

- Algoritmo (Portugol - Pseudocódigo)
    
    ```bash
    Início
        Escreva (“Hello World”);
    Fim.
    ```
    
- Código Fonte em Pascal
    
    ```pascal
    uses crt; // Biblioteca do Pascal
    begin
        writeln('Hello World');
    end.
    ```
    

## Olá Mundo em C#

Código Fonte em C#

```c
using System; // Biblioteca do .NET
class MainClass // Classe da Aplicação
{
    public static void Main() // Método Principal
    {
    Console.WriteLine("Hello World"); // Instrução
    }
}
```

## Links .NET e C#

- .NET - [https://dotnet.microsoft.com/](https://dotnet.microsoft.com/)
- Visual Studio - [https://visualstudio.microsoft.com/pt-br/](https://visualstudio.microsoft.com/pt-br/)
- VS Code - [https://code.visualstudio.com/](https://code.visualstudio.com/)
- Visual Studio for Mac - [https://visualstudio.microsoft.com/pt-br/vs/mac/](https://visualstudio.microsoft.com/pt-br/vs/mac/)
- MonoDevelop - [https://www.monodevelop.com/](https://www.monodevelop.com/)
- Docs Microsoft - [https://docs.microsoft.com/pt-br/welcome-to-docs](https://docs.microsoft.com/pt-br/welcome-to-docs)
- Guia de C# - [https://docs.microsoft.com/pt-br/dotnet/csharp/](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- Tutorial de C# Online - [https://dotnet.microsoft.com/learn/dotnet/in-browser-tutorial/1](https://dotnet.microsoft.com/learn/dotnet/in-browser-tutorial/1)

## Referências

- Microsoft Visual C# 2010 – Passo a passo, John Sharp, Bookman, 2010
- Introdução ao .NET
    - [https://docs.microsoft.com/pt-br/dotnet/core/introduction](https://docs.microsoft.com/pt-br/dotnet/core/introduction)
- Um tour pela linguagem C#
    - [https://docs.microsoft.com/pt-br/dotnet/csharp/](https://docs.microsoft.com/pt-br/dotnet/csharp/)

---