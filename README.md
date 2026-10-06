# Consumer Cat Fact API

Aplicação de console em C# para consumir a API pública **Cat Fact** e exibir uma curiosidade aleatória sobre gatos.

## Funcionamento

A aplicação faz uma requisição para:

```text
https://catfact.ninja/fact
```

A resposta JSON é convertida para um objeto C# e o fato recebido é exibido no terminal.

## Tecnologias

- C#
- .NET
- `HttpClient`
- Newtonsoft.Json
- API REST

## Arquivos principais

- `Program.cs` — fluxo principal e chamada à API.
- `CatFact.cs` — modelo utilizado para representar a resposta.
- `ConsumerGatinho.csproj` — configuração do projeto e dependências.

## Como executar

Com o .NET SDK instalado:

```bash
dotnet restore
dotnet run
```

## Objetivo

Projeto acadêmico voltado à prática de consumo de APIs REST, requisições HTTP e desserialização de JSON.
