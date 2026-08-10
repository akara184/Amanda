using Microsoft.EntityFrameworkCore;
using Amanda.Application.Models;
using Amanda.Infrastructure.Data;
using Amanda.Domain.Entities;
using System.Globalization;

namespace Amanda.Application.Services.UserServices;


public class UserServices : IUserService {

    private readonly UserDbContext _context;

    public UserServices(UserDbContext context){
        _context = context;
    }

    public  async Task<IEnumerable<UserResponseModel>> GetAllUsersAsync(){

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
    
    public async Task<UserResponseModel?> GetUserByIdAsync(int Id){

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
    public async Task<UserResponseModel> CreateUserAsync(UserRequestModel request){
        
        DateTime localDate = DateTime.UtcNow;

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
        // nao tem verificacao de duplicada
    }

    public async Task<bool> UpdateUserAsync(int id, UserRequestModel request){
        
        var userDb = await _context.Users.FindAsync(id);
        if (userDb is null)
        {
            return false;
        }
        try {
            
            userDb.Email = request.Email;
            userDb.Username = request.Username;
            userDb.Password = request.Password;

            await _context.SaveChangesAsync();
            return true;
        } catch (DbUpdateException){
            return false;
        }

        //nao tem verificao de duplicada

    }

    public async Task<bool> DeleteUserAsync(int id){

        var deleteUser = await _context.Users.FindAsync(id);
        
        if (deleteUser is null)
        {
            return false;
        }

        _context.Users.Remove(deleteUser);
        await _context.SaveChangesAsync();
        
        return true; 

    }

    
}

