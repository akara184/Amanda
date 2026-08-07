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

        // Tem como melhorar a lógica, deixo isso para depois
    }
    
    public async Task<UserResponseModel?> getUserByIdAsync(int Id){

        var userById = await _context.Users.FindAsync(Id);

        if (userById is null){
            return null;
        }
        
        var userResponse = new UserResponseModel
        {
            Id = userById.Id,
            Username = userById.Username,
            Email = userById.Email,
        };

        return userResponse;

    }
    public async Task<UserResponseModel> createUserAsync(UserRequestModel request){
        
        // UserResponseModel userModel = new UserResponseModel();
        DateTime localDate = DateTime.UtcNow;

        var getDupUser = _context.Users.Where(db => db.Email == request.Email || db.Username == request.Username);

        var createrUser = new User
        {
            Username = request.Username,
            Email  = request.Email,
            Password = request.Password,
            Date_time = localDate,
        };

        _context.Users.Add(createrUser);
        await _context.SaveChangesAsync();
        
        var returnUser = new UserResponseModel
        {
            Id = createrUser.Id,
            Username = createrUser.Username,
            Email = createrUser.Email,
        };

        return returnUser;

    }

    public async Task<bool> updateUserAsync(int id, UserRequestModel request){

        var user_db = await _context.Users.Where(db => db.Id == id);

        

    }

    public async Task<bool> deleteUserAsync(int id){

        var deleteUser = await _context.Users.FindAsync(id);
        
        if (deleteUser is null)
        {
            return false;
        }

        _context.Users.Remove(deleteUser);
        await _context.SaveChangesAsync();
        
        return true; // 



    }

    
}

