using Microsoft.AspNetCore.Mvc;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;


namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly WebDbContext _context;
    public ProductController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet("[action]")]
    public IActionResult GetList()
    {
        return Ok(_context.Products.ToList());
    }

    [HttpGet("[action]")]
    public IActionResult GetById(int id)
    {
        return Ok(_context.Products.FirstOrDefault(p => p.Id == id));
    }

    [HttpPost("[action]")]
    public IActionResult Create(Product product)
    {
        _context.Products.Add(product);
        return Ok(_context.SaveChanges());
    }

    [HttpPut("[action]")]
    public IActionResult Update(Product product)
    {
        _context.Products.Update(product);
        return Ok(_context.SaveChanges());
    }

    [HttpDelete("[action]")]
    public IActionResult Delete(int id)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == id);
        _context.Products.Remove(product);
        return Ok(_context.SaveChanges());
    }
}
