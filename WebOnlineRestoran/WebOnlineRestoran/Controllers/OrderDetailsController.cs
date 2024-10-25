using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class OrderDetailsController : ControllerBase
{
    private readonly WebDbContext _context;
    public OrderDetailsController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet]
    public IActionResult GetList()
    {
        return Ok(_context.OrderDetails.ToList());
    }

    [HttpGet]
    public IActionResult GetById(int id)
    {
        return Ok(_context.OrderDetails.FirstOrDefault(x => x.Id == id));
    }

    [HttpPost]
    public IActionResult Create(OrderDetails details)
    {
        _context.OrderDetails.Add(details);
        return Ok(_context.SaveChanges());
    }

    [HttpPut]
    public IActionResult Update(OrderDetails details)
    {
        _context.OrderDetails.Update(details);
        return Ok(_context.SaveChanges());
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var details = _context.OrderDetails.FirstOrDefault(i => i.Id == id);
        _context.OrderDetails.Remove(details);
        return Ok(_context.SaveChanges());
    }
        
}
