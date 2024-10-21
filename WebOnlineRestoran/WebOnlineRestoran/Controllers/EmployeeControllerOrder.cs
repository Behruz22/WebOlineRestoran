using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

public partial class EmployeeController
{
    [HttpGet("Order ID")]
    public async Task<Order> GetById(int id)
    {
        var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
        return order;
    }
    [HttpPost("Order add")]
    public async Task<int> CreatedOrder(Order order)
    {
        _context.Orders.Add(order);
        return await _context.SaveChangesAsync();
    }
    [HttpPut("Order Update")]
    public async Task<int> UpdateOrder(Order order)
    {
        _context.Orders.Update(order);
        return await _context.SaveChangesAsync();
    }
    [HttpDelete("Order Delete")]
    public async Task<int> DeletedOrder(int id)
    {
        var order= await _context.Orders.FirstOrDefaultAsync(o=>o.Id==id);
        _context.Orders.Remove(order);
        return await _context.SaveChangesAsync();
    }
}
