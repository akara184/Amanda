## Julia: 
0. projeto de referência GNU do dunossauro: https://fastapidozero.dunossauro.com e https://github.com/dotnet-architecture/eShopOnWbe
 
0.1.  objetivos:
     - Aprender sobre clean architecture e o ambiente .NET/ASPNET

1. https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/ < estrutura 
2. https://www.singhsk.com/posts/2026/03/project_structure_solutions_csproj_nuget_build_outputs/ < sobre o sln e csproj
3. https://emacs-lsp.github.io/lsp-mode/page/lsp-csharp-ls/#installation < fazer o LSP no emacs andar < mudanças de planos, estou usando eglot e gostando mt
4. https://wiki.archlinux.org/title/.NET < SDK no ARCHLINUX
5. https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new < algumas docs do dotnet - new 
6. https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/crud?view=aspnetcore-10.0 < ASPNET tem uma doc para criar um CRUD
7. https://learn.microsoft.com/en-us/dotnet/core/tools/ < referência das tools
8. https://medium.com/@danceforrasputin/-411a365022f4 < referencia da Arquitetura
9. https://wiki.archlinux.org/title/PostgreSQL#Initial_configuration < for some reason meu PG nao ta instalado
10. https://stackoverflow.com/questions/77700061/why-is-dotnet-new-webapi-command-not-producing-the-controllers-folder < api minimal ou usando controller
11. https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln < como usar o sln
12. https://www.c-sharpcorner.com/article/building-a-powerful-asp-net-core-web-api-with-postgresql/ < configurando banco de dados
13. https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures < Arquitetura 
14. https://medium.com/@erickson_dias/clean-architecture-compreendendo-e-aplicando-a-arquitetura-limpa-9ff1e84678cd < otimo para clear arch
15. https://learn.microsoft.com/en-us/ef/core/cli/dotnet < EF CORE, o migrations para o banco de dados funcionar 
    * Ao meu ver, o ambiente te "encoraja" a usar um banco de dados evolutivo, pois o mesmo migrations faz sentido em diversos cenários
      Algo bastante prático, e simples de usar. < Gostei 
16. https://www.nuget.org/ < POGGERS descobri isso 
17. https://dotnettutorials.net/lesson/services-in-asp-net-core-web-api/ < criando um service e interface
18. https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/async-scenarios < Estou criando as interfaces, olhando o Task para deixar Async
19. https://macoratti.net/23/06/net_dataannota1.htm < Usando data annotation 
20. https://learn.microsoft.com/en-us/archive/msdn-technet-forums/1ad08507-6dcc-44d1-ba86-2147a8fb1924 < diferença do notation do email
21. https://learn.microsoft.com/pt-br/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-10.0 < sobre dependências
22. 
23. 


o EF CORE é legal, meio que o ambiente te guia a fazer um banco de dados evolutivo, e EF core é fácil de usar 


estava colocado tbm em Async 





## Flavia:
1. Usaremos .NET 10 

### 3. Tecnologias da Flavia: 
- 3.1 .NET CLI < (mexer na estrutura do projeto) 
- 3.2 .ASP CORE < (Exatamente)
- 3.3  XUNIT < para teste
- 3.4 

## Amanda diz:
1. Não fecharemos com a MICROSOFT
2. nuget facilidade algumas coisas
3. Controllers vai ter conexao com a interface
4. Preciso criar uns Models para quando fazer uma requisição nao expor dados sensíveis 
5. Preciso ver um tal de Razor, é algo para poder criar um website mais fácil? nao sei se vou usar,
   o objetivo seria somente criar um endpoint e usar swagger para manipular eles
6. Por algum motivo isso tudo me lembra muito fazendo ts + angular na faculdade
7. É tentador em OOP criar custom exceptions, mas estou com uma baita preguiça


## Carol só fala:
- projeto precisa ficar registrando o slnx 
dotnet sln Amanda.slnx add src/Amanda.Api/Amanda.Api.csproj
dotnet sln Amanda.slnx add src/Amanda.Application/Amanda.Application.csproj
dotnet sln Amanda.slnx add src/Amanda.Domain/Amanda.Domain.csproj
dotnet sln Amanda.slnx add src/Amanda.Infrastructure/Amanda.Infrastructure.csproj

para adicionar referencias: 
dotnet add reference ../Amanda.Domain/Amanda.Domain.csproj


preciso do EF para criar as referencias pro banco: 

dotnet ef migrations add CreatingDatabase \
  -p src/Amanda.Infrastructure \
  -s src/Amanda.Api

-p pasta do banco, onde salva as paradas
-s source é onde ta a connection do settings que a gente fez 

Criar as tabelas no DB
dotnet ef database update \
  -p src/Amanda.Infrastructure \
  -s src/Amanda.Api





dotnet ef migrations add NomeDescritivoDaMudanca -p src/Amanda.Infrastructure -s src/Amanda.Api
dotnet ef database update -p src/Amanda.Infrastructure -s src/Amanda.Api

dotnet ef migrations list -p src/Amanda.Infrastructure -s src/Amanda.Api


dotnet ef database drop -p src/Amanda.Infrastructure -s src/Amanda.Api
dotnet ef database update -p src/Amanda.Infrastructure -s src/Amanda.Api

