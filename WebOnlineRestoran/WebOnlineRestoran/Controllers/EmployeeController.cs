using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]")]
public partial class EmployeeController : ControllerBase
{
    private readonly WebDbContext _context;
    public EmployeeController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }
    [HttpGet("Category List")]
    public async Task<List<Category>> GetCategoryList()
    {
        return await _context.Categories.ToListAsync();
    }
    [HttpGet("Food List")]
    public async Task<List<Food>> GetFoods()
    {
        return await _context.Foods.ToListAsync();
    }
}
