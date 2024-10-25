using Microsoft.AspNetCore.Mvc;
using WebOnlineRestoran.Data;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentController : ControllerBase
{
    private readonly WebDbContext _context;
    public PaymentController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }

    [HttpGet("[action]")]
    public IActionResult GetList()
    {
        return Ok(_context.Payments.ToList());
    }

    [HttpGet("[action]")]
    public IActionResult GetById(int id)
    {
        return Ok(_context.Payments.ToList());
    }

    [HttpPost("[action]")]
    public IActionResult Create(Payment payment)
    {
        _context.Payments.Add(payment);
        return Ok(_context.SaveChanges());
    }

    [HttpDelete("[action]")]
    public IActionResult Delete(int id)
    {
        var payment = _context.Payments.FirstOrDefault(x => x.Id == id);
        _context.Payments.Remove(payment);
        return Ok(_context.SaveChanges());
    }

    [HttpPut("[action]")]
    public IActionResult UpdatePayment(Payment payment)
    {
        _context.Payments.Update(payment);
        return Ok(_context.SaveChanges());
    }
}
