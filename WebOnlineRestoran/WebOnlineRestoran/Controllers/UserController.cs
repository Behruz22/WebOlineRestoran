using Microsoft.AspNetCore.Mvc;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class UserController : ControllerBase
{
    private readonly WebDbContext _context;
    public UserController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet]
    public IActionResult GetList()
    {
        return Ok(_context.Users.ToList());
    }
        
    [HttpGet]
    public IActionResult GetById(int id)
    {
        return Ok(_context.Users.FirstOrDefault(u => u.Id == id));
    }

    [HttpPost]
    public IActionResult Create(User user)
    {
        _context.Users.Add(user);
        return Ok(_context.SaveChanges());
    }

    [HttpPut]
    public IActionResult Update(User user)
    {
        _context.Users.Update(user);
        return Ok(_context.SaveChanges());
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var user = _context.Users.FirstOrDefault(x => x.Id == id);
        _context.Users.Remove(user);
        return Ok(_context.SaveChanges());
    }
}
