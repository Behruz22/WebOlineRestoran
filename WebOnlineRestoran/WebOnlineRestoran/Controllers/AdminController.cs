using Microsoft.AspNetCore.Mvc;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AdminController : ControllerBase
{
    private readonly WebDbContext _context;
    public AdminController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet]
    public IActionResult GetList()
    {
        return Ok(_context.Admins.ToList());
    }

    [HttpGet]
    public IActionResult GetById(int id)
    {
        return Ok(_context.Admins.Where(a => a.Id == id));
    }

    [HttpPost]
    public IActionResult Create(Admin admin)
    {
        _context.Admins.Add(admin);
        return Ok(_context.SaveChanges());
    }

    [HttpPut]
    public IActionResult Update(Admin admin)
    {
        _context.Admins.Update(admin);
        return Ok(_context.SaveChanges());
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var admin = _context.Admins.FirstOrDefault(x => x.Id == id);
        _context.Admins.Remove(admin);
        return Ok(_context.SaveChanges());
    }
}
