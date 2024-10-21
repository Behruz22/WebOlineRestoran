using Microsoft.AspNetCore.Mvc;
using WebOnlineRestoran.Data;

namespace WebOnlineRestoran.Controllers;

[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase
{
    private readonly WebDbContext _context;
    public ReportController(WebDbContext webDbContext)
    {
        _context = webDbContext;
    }
    
}
