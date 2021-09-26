using API.Data;
using API.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsersController :ControllerBase
    
    {
        private readonly DataContext _context;
       public UsersController(DataContext context){
            _context= context;
        } 

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){        
        var user = _context.Users.ToListAsync();
        return await user;
    }

    [HttpGet("{id}")] 
    public  async Task<ActionResult<AppUser>> GetUser(int id){
        var user = _context.Users.FindAsync(id);
        return await user;
    }
        
    }
}