using Microsoft.AspNetCore.Mvc;
using Cuzicuza.Server.Data;
using Cuzicuza.Server.Models;
using Cuzicuza.Shared;
using System.Threading.Tasks;




namespace Cuzicuza.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly DataContext _context;

        public ContactController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact([FromBody] ContactDto contactDto)
        {
            var contact = new Contact
            {
                Name = contactDto.Name,
                Email = contactDto.Email,
                Message = contactDto.Message
            };

            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
