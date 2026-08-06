using Amanda.Application.Models;
using Amanda.Infrastructure.Data;
namespace Amanda.Application.Services.User;

public class UserServices : IUserService {


    private readonly UserDbContext _context;

    public UserServices(UserDbContext context){
        _context = context;
    }

    public Task<IEnumerable<UserResponseModel>> GetAllUsersAsync(){

        throw new NotImplementedException();

    }
    
    public Task<UserResponseModel?> GetUserByIdAsync(int Id){

        throw new NotImplementedException();
    }
    public Task<UserResponseModel> CreateUserAsync(UserRequestModel request){
        
        throw new NotImplementedException();
        
    }

    public Task<bool> UpdateUserAsync(int id, UserRequestModel request){

        throw new NotImplementedException();
    }

    public Task<bool> DeleteUserAsync(int id){

        throw new NotImplementedException();
        
    }

    
}

