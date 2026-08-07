using Amanda.Application.Models;

namespace Amanda.Application.Services.UserServices;

public interface IUserService
{
    
    Task<IEnumerable<UserResponseModel>> getAllUsersAsync();
    
    Task<UserResponseModel?> getUserByIdAsync(int Id);

    Task<UserResponseModel> createUserAsync(UserRequestModel request);

    // Nesses dois vou retornar um bool? tipo é melhor sempre retornar algo, mas um bool? é preguiçoso mas acho que vai 
    Task<bool> updateUserAsync(int id, UserRequestModel request);

    Task<bool> deleteUserAsync(int id);

    
    
}


// > Task deixa Async
// https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/async-scenarios
// Task<> se eu quiser retorar o valor, eu posso colocar algo no generics, ou seja qual tipo de valor ele vai carregar
// Task CreateUser(UserRequestModel request); cria porem nao retorna nada. Eu vou retornar pq se caso eu usar
// > Tudo Async precisa ter nome Async, pois é mais fácil de saber que estamos lidando com algo async

// o ? no <> é uma opção, pode retorna null
