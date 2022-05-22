# Guia de Uso do GitHub

## Objetivos

- Conhecer o GitHub
- Utilizar o GitHub com o [repl.it](http://repl.it/)

## GitHub

- O GitHub é uma plataforma de hospedagem utilizada para controle de versão e desenvolvimento colaborativo
    - Repositório de documentos e código-fonte
    - Controle de versão
    - Registro de projetos e tarefas
    - Fórum de discussão
    - Relatórios de atividades

## GitHub – Repositório Pessoal

- Passos para armazenamento de projetos no GitHub integrado ao [repl.it](http://repl.it/)
    - Registro, login, criação do repositório (remoto) no site do GitHub
    - Criação de pastas e arquivos no GitHub
    - Clonagem do repositório no [repl.it](http://repl.it/)
    - Configuração do [repl.it](http://repl.it/) para execução de programas copiados do repositório
    - Criação de novos programas no repositório local com o [repi.it](http://repi.it/)
    - Confirmação de alterações no repositório local
    - Sincronização das alterações com o repositório (remoto)

## GitHub – Repositório Pessoal

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/6c28ad80-aa6e-42d6-a6e3-ad039b161547/Untitled.png)

## Registro no GitHub

- [https://github.com/](https://github.com/)

## Novo Repositório

- Crie um novo repositório no GitHub, selecionado Create repository

## Nomeando o Repositório

- Defina um nome para o repositório

## Página do Repositório

- A página mostra os dados do repositório: código, tarefas (questões), solicitações Pull, ações, projetos, Wiki, ...

## Criando uma Pasta

- Selecione creating a new file para adicionar pastas e arquivos ao repositório

## Nomeando a Pasta e o Arquivo

- Na caixa de texto, digite “Aula 01”. A pasta é criada quando uma “/” for digitada.
- Digite o nome do arquivo “OlaMundo.cs”.

## Digitando o Arquivo

- Digite o código do OlaMundo.cs no editor
- Confirme a criação do arquivo no botão Commit

## Visualizando o Repositório

- Selecione Add file/Create new file para adicionar um novo arquivo

## Adicionando outro Arquivo

- Repita o procedimento anterior. Crie a pasta “Aula 02” e o arquivo “AreaTriangulo.cs”
- Confirme a criação do arquivo no botão Commit

## Visualizando o Repositório

- As pastas Aula 01 e Aula 02 são apresentadas no repositório

## Clonando o Repositório no [repl.it](http://repl.it/)

- No [repl.it](http://repl.it/), selecione New repl e em seguida Import From GitHub
    - Informe o repositório a ser clonado

## Configurando a Linguagem

- Informe a linguagem de programação e selecione Done
    - O repositório é apresentado na página Files do [repl.it](http://repl.it/)

## Configurando o Comando Run

- Informe no comando run do arquivo .replit do repositório, o arquivo do repositório que vai ser executado
    
    ```csharp
    language = "csharp"
    run = "mcs -out:main.exe 'Aula 01/OlaMundo.cs' ; mono main.exe"
    ```
    

## Executando o Programa

- Após informar o arquivo no run, é só executar o programa

## Criando uma Pasta no [repl.it](http://repl.it/)

- Selecione Add folder para inserir uma nova pasta Aula 03
- Na pasta Aula 03, selecione Add a File

## Criando um Arquivo no [repl.it](http://repl.it/)

- Adicione o arquivo “uri_1001.cs” e digite o código do programa
- Ajuste o comando run no arquivo .replit e execute o programa
    
    ```csharp
    run = "mcs -out:main.exe 'Aula 03/uri_1001.cs' ; mono main.exe"
    ```
    

## Confirmando as Alterações

- Selecione o botão Version control para confirmar as alterações.
    - Informe um texto com as alterações realizadas no repositório
    - Selecione o botão Commit & push para confirmar

## Enviando as Alterações

- O commit deixa a versão no [repl.it](http://repl.it/) uma versão a frente do GitHub
- Para atualizar o GitHub, execute o comando push no terminal do [repl.it](http://repl.it/)
    - git push

## GitHub Atualizado

## Referências

- GitHub: [https://github.com/](https://github.com/)
- GitHub Get Started: [https://docs.github.com/pt/get-started](https://docs.github.com/pt/get-started)
- GitHub Learning Lab: [https://lab.github.com/](https://lab.github.com/)