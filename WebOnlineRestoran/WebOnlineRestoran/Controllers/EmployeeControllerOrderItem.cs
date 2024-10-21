using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

public partial class EmployeeController
{
    [HttpGet("Order Item Id")]
    public async Task<OrderItem> GetOrderItems(int id)
    {
        var orderItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
        return  orderItem;
    }
    [HttpPost("Order Item Created")]
    public async Task<int> CreatedItem(OrderItem orderItem)
    {
        _context.Items.Add(orderItem);
        return await _context.SaveChangesAsync();
    }

    [HttpPut("Update Order Item")]
    public async Task<int> UpdateItem(OrderItem orderItem)
    {
        _context.Items.Update(orderItem);
        return await _context.SaveChangesAsync();
    }

    [HttpDelete("Delete OrderItem")]
    public async Task<int> DeleteItem(int id)
    {
        var item = await _context.Items.FirstOrDefaultAsync(i => i.Id == id);
        if (item != null)
            _context.Items.Remove(item);
        return await _context.SaveChangesAsync();
    }
        
}
