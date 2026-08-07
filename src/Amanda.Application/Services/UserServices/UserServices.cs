using Microsoft.EntityFrameworkCore;
using Amanda.Application.Models;
using Amanda.Infrastructure.Data;
using Amanda.Domain.Entities;
using System.Globalization;

namespace Amanda.Application.Services.UserServices;


public class UserServices : IUserService {

    // um truquezinho de injeção, para os metodos usar o _context é necessário aparecer no costrutor 
    private readonly UserDbContext _context;

    public UserServices(UserDbContext context){
        _context = context;
    }

    public  async Task<IEnumerable<UserResponseModel>> getAllUsersAsync(){

        var getUsersCatalog = await _context.Users.ToListAsync();

        var users = getUsersCatalog.Select(users =>
        {
            var allUsers = new UserResponseModel
            {
                Id = users.Id,
                Username = users.Username,
                Email = users.Email,
            };
            return allUsers;
        }).ToList(); 

        return users;

        // Tem como melhorar a lógica
    }
    
    public async Task<UserResponseModel?> getUserByIdAsync(int Id){

        throw new NotImplementedException();

    }
    public async Task<UserResponseModel> createUserAsync(UserRequestModel request){
        
        // UserResponseModel userModel = new UserResponseModel();
        DateTime localDate = DateTime.UtcNow;

        var getDupUser = _context.Users.Where(db => db.Email == request.Email || db.Username == request.Username);

        var createUser = new User
        {
            Username = request.Username,
            Email  = request.Email,
            Password = request.Password,
            Date_time = localDate,
        };

        _context.Users.Add(createUser);
        await _context.SaveChangesAsync();
        
        var cleanUser = new UserResponseModel
        {
            Id = createUser.Id,
            Username = createUser.Username,
            Email = createUser.Email,
        };

        return cleanUser;

    }

    public async Task<bool> updateUserAsync(int id, UserRequestModel request){

        throw new NotImplementedException();
    }

    public async Task<bool> deleteUserAsync(int id){
        
        throw new NotImplementedException();
        
    }

    
}

