using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOnlineRestoran.Models;

namespace WebOnlineRestoran.Controllers
{
    public partial class AdminController
    {
        [HttpPost("Food Add")]
        public async Task<int> CreatedProduct(Food food)
        {
            _context.Foods.Add(food);
            return await _context.SaveChangesAsync();
        }

        [HttpGet("Food List")]
        public async Task<List<Food>> GetFoodList()
        {
            return await _context.Foods.ToListAsync();
        }

        [HttpPut("Update Food")]
        public async Task<int> UpdateFood(Food food)
        {
            _context.Foods.Update(food);
            return await _context.SaveChangesAsync();
        }

        [HttpDelete("Delete Food")]
        public async Task<int> DeleteFood(int id)
        {
            var food= await _context.Foods.FirstOrDefaultAsync(x => x.Id == id);
            if (food != null)
                _context.Foods.Remove(food);
            return await _context.SaveChangesAsync();
        }
    }
}
