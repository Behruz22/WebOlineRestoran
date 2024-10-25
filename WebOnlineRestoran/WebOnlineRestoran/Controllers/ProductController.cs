using Microsoft.AspNetCore.Mvc;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;


namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ProductController : ControllerBase
{
    private readonly WebDbContext _context;
    public ProductController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet]
    public IActionResult GetList()
    {
        return Ok(_context.Products.ToList());
    }

    [HttpGet]
    public IActionResult GetById(int id)
    {
        return Ok(_context.Products.FirstOrDefault(p => p.Id == id));
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        _context.Products.Add(product);
        return Ok(_context.SaveChanges());
    }

    [HttpPut]
    public IActionResult Update(Product product)
    {
        _context.Products.Update(product);
        return Ok(_context.SaveChanges());
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == id);
        _context.Products.Remove(product);
        return Ok(_context.SaveChanges());
    }
}
