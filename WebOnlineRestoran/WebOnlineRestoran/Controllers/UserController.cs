using Microsoft.AspNetCore.Mvc;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly WebDbContext _context;
    public UserController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet("[action]")]
    public IActionResult GetList()
    {
        return Ok(_context.Users.ToList());
    }

    [HttpGet("[action]")]
    public IActionResult GetById(int id)
    {
        return Ok(_context.Users.FirstOrDefault(u => u.Id == id));
    }

    [HttpPost("[action]")]
    public IActionResult Create(User user)
    {
        _context.Users.Add(user);
        return Ok(_context.SaveChanges());
    }

    [HttpPut("[action]")]
    public IActionResult Update(User user)
    {
        _context.Users.Update(user);
        return Ok(_context.SaveChanges());
    }

    [HttpDelete("[action]")]
    public IActionResult Delete(int id)
    {
        var user = _context.Users.FirstOrDefault(x => x.Id == id);
        _context.Users.Remove(user);
        return Ok(_context.SaveChanges());
    }
}
