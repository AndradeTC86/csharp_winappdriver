# C# WinAppDriver

# Automação Desktop Utilizando C# e WinAppDriver

Esse é um repositório de automação de testes, desenvolvido para fazer automação de testes desktop utilizando C# em conjunto com Selenium Webdriver, Appium e NUnit.

## Table of Contents

1. [Objetivo](#objetivo)
2. [Estrutura do projeto](#estrutura-do-projeto)
3. [Setup inicial](#setup-inicial)

## Objetivo

O objetivo desse projeto é criar uma automação desktop da Calculadora do Windows para treinamento do WinAppDriver com C#.

## Estrutura do projeto

```
|--- apps
|--- tests
|--- csharp-winappdriver.slnx
|--- csharp_winappdriver.csproj
```

## Executando os testes

### Pré-requisitos

1. [Git](https://git-scm.com/) 
2. [WinAppDriver](https://github.com/microsoft/WinAppDriver) `Latest Version`   
3. [C#](https://dotnet.microsoft.com/pt-br/languages/csharp) 

### Setup inicial

1. Restaurar as dependências do projeto através do comando `dotnet restore`
2. Após a restauração, compilar o projeto através do comando `dotnet build`
3. Instalar o WinAppDriver na máquina local
4. Ativar o modo desenvolvedor na máquina local

### Como executar os testes

1. Inicie o **WinAppDriver**. Por padrão, o executável fica localizado em: `C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe`
2. Execute a suíte de testes na raiz do projeto utilizando o comando:
```bash
dotnet test
```