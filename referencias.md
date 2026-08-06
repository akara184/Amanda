## Julia: 
0. projeto de referência GNU do dunossauro: https://fastapidozero.dunossauro.com 

1. https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/ < estrutura 
2. https://www.singhsk.com/posts/2026/03/project_structure_solutions_csproj_nuget_build_outputs/ < sobre o sln e csproj
3. https://emacs-lsp.github.io/lsp-mode/page/lsp-csharp-ls/#installation < fazer o LSP no emacs andar 
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
15. https://learn.microsoft.com/en-us/ef/core/cli/dotnet < ef, o migrations para o banco de dados funcionar 
    * Ao meu ver, o ambiente te o "obriga" a usar um banco de dados evolutivo, pois o mesmo migrations faz sentido em diversos cenários
      Algo bastante prático, e simples de usar. 
16. https://www.nuget.org/ < POGGERS descobri isso 

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
4. 

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
