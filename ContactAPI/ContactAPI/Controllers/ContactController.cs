using Microsoft.AspNetCore.Mvc;
using ContactAPI.Models;
using ContactAPI.Services;


namespace ContactAPI.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
      private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: api/contact
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contacts = await _contactService.GetAllContactsAsync();
            return Ok(contacts);
        }

        // GET: api/contact/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var contact = await _contactService.GetContactByIdAsync(id);
            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        // POST: api/contact
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Contact contact)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _contactService.AddContactAsync(contact);
            return CreatedAtAction(nameof(Get), new { id = contact.Id }, contact);
        }

        // PUT: api/contact/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Contact contact)
        {
            if (id != contact.Id)
                return BadRequest("ID mismatch");

            await _contactService.UpdateContactAsync(contact);
            return NoContent();
        }

        // DELETE: api/contact/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    await _contactService.DeleteContactAsync(id);
        //    return NoContent();
        //}
    }
}

