# blazor-jsonplaceholder-api-net

Lista de Exercícios — Desenvolvimento Web (Usabilidade, Dev. Web, Mobile e Jogos)
Professor Daniel Henrique Matos de Paiva

Aplicação **Blazor** (.NET 8) chamada `BlazorUsersJsonPlaceHolderApi` que consome o endpoint
`https://jsonplaceholder.typicode.com/users` e imprime no console os dados da **primeira** pessoa retornada:

```
Nome: Leanne Graham
Cidade: Gwenborough
Empresa: Romaguera-Crona
```

Os mesmos dados também aparecem na página inicial da aplicação.

## Como executar

```bash
dotnet run
```

## Estrutura

- `Models/User.cs` — modelos `User`, `Address` e `Company`
- `Services/UserService.cs` — consumo da API com `HttpClient` e impressão no console
- `Program.cs` — registro do serviço e impressão no console ao iniciar
- `Components/Pages/Home.razor` — exibição na tela
