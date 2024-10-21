using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers;

public partial class EmployeeController
{
    [HttpGet("Payment Id")]
    public async Task<List<Payment>> GetById()
    {
        return _context.Payments.ToList();
    }
    [HttpPost("Payment Created")]
    public async Task<int> CreatedPayment(Payment payment)
    { 
        _context.Payments.Add(payment);
        return await _context.SaveChangesAsync();
    }

    [HttpDelete("Payment Delete")]
    public async Task<int> DeletedPayment(int id)
    {
        var payment=await _context.Payments.FirstOrDefaultAsync(x => x.Id == id);
        if (payment != null) 
            _context.Payments.Remove(payment);
        return await _context.SaveChangesAsync();
    }

    [HttpPut("Update Payment")]
    public async Task<int> UpdatePayment(Payment payment)
    {
        _context.Payments.Update(payment);
        return await _context.SaveChangesAsync();
    }


}
