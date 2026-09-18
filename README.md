# Amanda

- https://wiki.c2.com/?BlubParadox
- Status: funciona, precisa refatorar. 
- Como rodar: `dotnet run` na `Amanda.Api` e acessar http://localhost:5043/swagger

---

## Julia - referências de estudo

**Projeto de referência:** GNU do dunossauro — https://fastapidozero.dunossauro.com e https://github.com/dotnet-architecture/eShopOnWbe

**Objetivos:**
- Aprender sobre clean architecture e o ambiente .NET/ASPNET

**Links:**

1. https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/ — estrutura
2. https://www.singhsk.com/posts/2026/03/project_structure_solutions_csproj_nuget_build_outputs/ — sobre o sln e csproj
3. https://emacs-lsp.github.io/lsp-mode/page/lsp-csharp-ls/#installation — fazer o LSP no emacs andar *(mudança de planos: estou usando eglot e gostando muito)*
4. https://wiki.archlinux.org/title/.NET — SDK no Arch Linux
5. https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new — algumas docs do `dotnet new`
6. https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/crud?view=aspnetcore-10.0 — ASPNET tem uma doc para criar um CRUD
7. https://learn.microsoft.com/en-us/dotnet/core/tools/ — referência das tools
8. https://medium.com/@danceforrasputin/-411a365022f4 — referência da arquitetura
9. https://wiki.archlinux.org/title/PostgreSQL#Initial_configuration — for some reason meu PG não tá instalado
10. https://stackoverflow.com/questions/77700061/why-is-dotnet-new-webapi-command-not-producing-the-controllers-folder — API minimal ou usando controller
11. https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln — como usar o sln
12. https://www.c-sharpcorner.com/article/building-a-powerful-asp-net-core-web-api-with-postgresql/ — configurando banco de dados
13. https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures — arquitetura
14. https://medium.com/@erickson_dias/clean-architecture-compreendendo-e-aplicando-a-arquitetura-limpa-9ff1e84678cd — ótimo para clean arch
15. https://learn.microsoft.com/en-us/ef/core/cli/dotnet — EF Core, o migrations para o banco de dados funcionar
    - Ao meu ver, o ambiente te "encoraja" a usar um banco de dados evolutivo, pois o mesmo migrations faz sentido em diversos cenários. Algo bastante prático e simples de usar *(gostei)*.
16. https://www.nuget.org/ — POGGERS, descobri isso
17. https://dotnettutorials.net/lesson/services-in-asp-net-core-web-api/ — criando um service e interface
18. https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/async-scenarios — estou criando as interfaces, olhando o Task para deixar async
19. https://macoratti.net/23/06/net_dataannota1.htm — usando data annotation
20. https://learn.microsoft.com/en-us/archive/msdn-technet-forums/1ad08507-6dcc-44d1-ba86-2147a8fb1924 — diferença do notation do e-mail
21. https://learn.microsoft.com/pt-br/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-10.0 — sobre dependências
22. https://stackoverflow.com/questions/54336578/cant-decide-between-taskiactionresult-iactionresult-and-actionresultthing — diferença entre `IActionResult` vs `ActionResult`
23. https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbupdateexception?view=efcore-10.0 — erro quando tenta salvar em database
24. https://dev.to/stevsharp/mastering-action-and-func-delegates-in-c-real-world-patterns-and-examples-5ggp — sobre `delegate`, `Func<>`, `Action<>` e `Expression<>`
25. https://stackoverflow.com/questions/793571/why-would-you-use-expressionfunct-rather-than-funct — sobre `Expression<Func<T>>`
    - Most times you're going to want Func or Action if all that needs to happen is to run some code. You need Expression when the code needs to be analyzed, serialized, or optimized before it is run. Expression is for thinking about code, Func/Action is for running it.

---

## Flavia (stack)

1. Usaremos .NET 10

**Tecnologias da Flavia:**

- 3.1. .NET CLI — mexer na estrutura do projeto
- 3.2. ASP.NET Core — exatamente
- 3.3. xUnit — para teste < Não fiz
- 3.4. *(a definir)*

---

## Amanda diz

1. Não fecharemos com a Microsoft
2. NuGet facilita algumas coisas
3. Controllers vai ter conexão com a interface
4. Preciso criar uns Models para, quando fazer uma requisição, não expor dados sensíveis
5. Preciso ver um tal de Razor — é algo para poder criar um website mais fácil? Não sei se vou usar; o objetivo seria somente criar um endpoint e usar Swagger para manipulá-los
6. Por algum motivo isso tudo me lembra muito fazendo TS + Angular na faculdade
7. É tentador em OOP criar custom exceptions, mas estou com uma baita preguiça
8. To com preguiça de colocar msg boa de erro, então só vai ser só erro mesmo
9. Notei algo: ao contrário de outros ambientes, tipo Spring Boot ou SQLAlchemy, que são bem mais "fáceis" para lidar com os erros, a integração com o banco de dados é mais simples. Ao contrário, em um ambiente C#/ASP/.NET parece que tudo precisa ser mais explícito, e o que deveria ser simples exige criar na marra um simples erro.

**Curried function em C#:**

```csharp
Func<int, Func<int, int>> somaCurried = a => b => a + b;

Func<int, int> soma5 = somaCurried(5);
int resultado = soma5(3); // 8
```

---

## Apenas coisas para lembrar

**Registrar projetos no slnx:**

```bash
dotnet sln Amanda.slnx add src/Amanda.Api/Amanda.Api.csproj
dotnet sln Amanda.slnx add src/Amanda.Application/Amanda.Application.csproj
dotnet sln Amanda.slnx add src/Amanda.Domain/Amanda.Domain.csproj
dotnet sln Amanda.slnx add src/Amanda.Infrastructure/Amanda.Infrastructure.csproj
```

**Adicionar referências:**

```bash
dotnet add reference ../Amanda.Domain/Amanda.Domain.csproj
```

**EF - criar migrations para o banco:**

```bash
dotnet ef migrations add CreatingDatabase \
  -p src/Amanda.Infrastructure \
  -s src/Amanda.Api
```

- `-p`: pasta do banco, onde salva as paradas
- `-s`: source, onde tá a connection do settings que a gente fez

**Criar as tabelas no DB:**

```bash
dotnet ef database update \
  -p src/Amanda.Infrastructure \
  -s src/Amanda.Api
```

**Fluxo geral de migrations:**

```bash
dotnet ef migrations add NomeDescritivoDaMudanca -p src/Amanda.Infrastructure -s src/Amanda.Api
dotnet ef database update -p src/Amanda.Infrastructure -s src/Amanda.Api
dotnet ef migrations list -p src/Amanda.Infrastructure -s src/Amanda.Api
```

**Resetar o banco:**

```bash
dotnet ef database drop -p src/Amanda.Infrastructure -s src/Amanda.Api
dotnet ef database update -p src/Amanda.Infrastructure -s src/Amanda.Api
```

- Organizei a estrutura do .md usando claude
