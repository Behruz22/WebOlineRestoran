using Microsoft.AspNetCore.Mvc;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CategoryController : ControllerBase
{
    private readonly WebDbContext _context;
    public CategoryController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet]
    public IActionResult GetList()
    {
        return Ok(_context.Categories.ToList());
    }

    [HttpGet]
    public IActionResult GetById(int id)
    {
        return Ok(_context.Categories.FirstOrDefault(c => c.Id == id));
    }

    [HttpPost]
    public IActionResult Create(Category category)
    {
        _context.Categories.Add(category);
        return Ok(_context.SaveChanges());
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var category = _context.Categories.FirstOrDefault(c => c.Id == id);
        _context.Categories.Remove(category);
        return Ok(_context.SaveChanges());
    }

    [HttpPut]
    public IActionResult Update(Category category)
    {
        _context.Categories.Update(category);
        return Ok(_context.SaveChanges());
    }
}
