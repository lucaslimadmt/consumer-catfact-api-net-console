# Consumer Cat Fact API

Projeto desenvolvido em **C# utilizando .NET** com o objetivo de praticar o consumo de uma API externa em uma aplicação de console.

A aplicação realiza uma requisição para a API **CatFact** e apresenta no terminal uma curiosidade aleatória sobre gatos.

## Funcionamento

Ao executar o programa, é realizada uma requisição HTTP para o seguinte endereço:

```text
https://catfact.ninja/fact
```

A API retorna os dados em formato JSON. A aplicação processa essa resposta e exibe o fato recebido diretamente no console.

## Tecnologias utilizadas

* C#
* .NET
* HttpClient
* Newtonsoft.Json
* API REST

## Objetivo

O projeto tem como objetivo colocar em prática conceitos relacionados a:

* Consumo de APIs REST;
* Requisições HTTP;
* Manipulação de respostas em JSON;
* Desserialização de dados;
* Desenvolvimento de aplicações utilizando C# e .NET.

## Execução

Para executar o projeto, é necessário ter o **.NET SDK** instalado.

Dentro da pasta do projeto, utilize:

```bash
dotnet restore
dotnet run
```

Após a execução, uma curiosidade sobre gatos será exibida no terminal.

## API

Os dados utilizados pela aplicação são fornecidos pela API pública **CatFact**:

```text
https://catfact.ninja/
```
