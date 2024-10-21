using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]")]
public partial class AdminController : ControllerBase
{
    private readonly WebDbContext _context;
    public AdminController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpPost("Category Add")]
    public int CreatedCategory(Category category)
    {
        _context.Categories.Add(category);
        return _context.SaveChanges();
    }

    [HttpGet("Category List")]
    public List<Category> GetCategoryList()
    {
        return _context.Categories.ToList();
    }

    [HttpDelete("Category Deleted")]
    public int DeletedCatgeory(int id)
    {
        var category = _context.Categories.FirstOrDefault(c=>c.Id==id);
        if (category != null)
        {
            _context.Categories.Remove(category);
        }
        return _context.SaveChanges();
    }

    [HttpPut("Category Update")]
    public int UpdateCategory(Category category)
    {
        _context.Categories.Update(category);
        return _context.SaveChanges();
    }
}
