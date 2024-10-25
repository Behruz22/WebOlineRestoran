using Microsoft.AspNetCore.Mvc;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class OrderController : ControllerBase
{
    private readonly WebDbContext _context;
    public OrderController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet]
    public IActionResult GetList()
    {
        return Ok(_context.Orders.ToList());
    }

    [HttpGet]
    public IActionResult GetById(int id)
    {
        return Ok(_context.Orders.FirstOrDefault(o => o.Id == id));
    }

    [HttpPost]
    public IActionResult Create(Order order)
    {
        _context.Orders.Add(order);
        return Ok(_context.SaveChanges());
    }

    [HttpPut]
    public IActionResult Update(Order order)
    {
        _context.Orders.Update(order);
        return Ok(_context.SaveChanges());
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var order = _context.Orders.FirstOrDefault(o => o.Id == id);
        _context.Orders.Remove(order);
        return Ok(_context.SaveChanges());
    }
}
