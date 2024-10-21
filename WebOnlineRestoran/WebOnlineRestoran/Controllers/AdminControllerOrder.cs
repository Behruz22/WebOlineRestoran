using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

public partial class AdminController
{
    [HttpGet("Order List")]
    public async Task<List<Order>> GetOrders()
    {
        return await _context.Orders.ToListAsync();
    }

    [HttpPatch("Status Add (id)")]
    public async Task<int> StatusOrder(int id, Status status)
    {
        var order = await _context.Orders.FirstOrDefaultAsync(order => order.Id == id);
        if (order != null)
        {
            order.Status = status;
            return await _context.SaveChangesAsync();
        }
        else
            return 0;
    }

    [HttpGet("Order Item List")]
    public async Task<List<Order>> GetOrderItems()
    {
        return await _context.Orders.ToListAsync();
    }

    [HttpGet("Payment List")]
    public async Task<List<Payment>> GetPayments()
    {
        return await _context.Payments.ToListAsync();
    }

    [HttpGet("User List")]
    public async Task<List<User>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }
}
