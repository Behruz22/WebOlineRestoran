using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]")]
public class UserAuthController : ControllerBase
{
    private readonly WebDbContext _context;
    public UserAuthController(WebDbContext webDbContext)
    {
        _context = webDbContext;
        
    }

    [HttpGet("User List")]
    public async Task<List<User>> UserList()
    {
        return await _context.Users.ToListAsync();
    }

    [HttpPost("User Add")]
    public async Task<int> UserCreated(User user)
    {
        var users = await _context.Users.Select(u=>u.Id).ToListAsync();
        if (users.Contains(user.Id))
        {
            _context.Users.Add(user);
        }
        return await _context.SaveChangesAsync();


    }

    [HttpPut("User Update")]
    public async Task<int> UserUpdate(User user)
    {
        _context.Users.Update(user);
        return await _context.SaveChangesAsync();
    }
    [HttpDelete("User Deleted")]
    public async Task<int> UserDeleted(int id) 
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
         _context.Users.Remove(user);
        return await _context.SaveChangesAsync();
    }
}
