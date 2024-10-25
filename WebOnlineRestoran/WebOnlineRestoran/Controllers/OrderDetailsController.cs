using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderDetailsController : ControllerBase
{
    private readonly WebDbContext _context;
    public OrderDetailsController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet("[action]")]
    public IActionResult GetList()
    {
        return Ok(_context.OrderDetails.ToList());
    }

    [HttpGet("[action]")]
    public IActionResult GetById(int id)
    {
        return Ok(_context.OrderDetails.FirstOrDefault(x => x.Id == id));
    }

    [HttpPost("[action]")]
    public IActionResult Create(OrderDetails details)
    {
        _context.OrderDetails.Add(details);
        return Ok(_context.SaveChanges());
    }

    [HttpPut("[action]")]
    public IActionResult Update(OrderDetails details)
    {
        _context.OrderDetails.Update(details);
        return Ok(_context.SaveChanges());
    }

    [HttpDelete("[action]")]
    public IActionResult Delete(int id)
    {
        var details = _context.OrderDetails.FirstOrDefault(i => i.Id == id);
        _context.OrderDetails.Remove(details);
        return Ok(_context.SaveChanges());
    }
        
}
