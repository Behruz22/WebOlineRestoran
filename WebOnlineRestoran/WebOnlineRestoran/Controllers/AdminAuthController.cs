using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]")]
public class AdminAuthController : ControllerBase
{
    private readonly WebDbContext _context;
    public AdminAuthController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet("Admin List")]
    public async Task<List<Admin>> AdminList()
    {
        return await _context.Admins.ToListAsync();
    }

    [HttpPost("Admin Add")]
    public async Task<int> AdminCreated(Admin admin)
    {
       

       _context.Admins.Add(admin);
        return await _context.SaveChangesAsync();
    }

    [HttpPut("Admin Update")]
    public async Task<int> AdminUpdate(Admin admin)
    {
        _context.Admins.Update(admin);
        return await _context.SaveChangesAsync();
    }

    [HttpDelete("Admin Deleted")]
    public async Task<int> AdminDeleted(int id)
    {
        var admin = await _context.Admins.FirstOrDefaultAsync(x => x.Id == id);
        _context.Admins.Remove(admin);
        return await _context.SaveChangesAsync();
    }
}
