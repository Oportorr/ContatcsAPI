using ContatcsAPI.Data;
using ContatcsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Numerics;

namespace ContatcsAPI.Controllers
{
    [ApiController]
    [Route("api/contacts")]
    public class ContactsController : Controller
    {
        public ContactsAPIDbContext DbContext { get; }
        public ContactsController(ContactsAPIDbContext dbContext) 
        {
            DbContext = dbContext;
        }

      

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {

            return  Ok(await DbContext.Contacts.ToListAsync());
        }


        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetContatcByID([FromRoute] Guid id)
        {
            var contact = await DbContext.Contacts.FindAsync(id);

            if (contact != null)
            {
                return Ok(contact);
            }
            return NotFound("");
        }


        [HttpPost]
        public async Task<IActionResult> AddContact(AddContactRequest addContactRequest)        
        {

            var contact = new Contact()
            {

                Id      = Guid.NewGuid(),
                Address = addContactRequest.Address,
                Email   = addContactRequest.Email,
                Name    = addContactRequest.Name,
                Phone   = addContactRequest.Phone,
                City    = addContactRequest.City,
                Country = addContactRequest.Country,

            };

            await DbContext.Contacts.AddAsync(contact);
            await DbContext.SaveChangesAsync();


            return Ok(contact);
        
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateContact([FromRoute] Guid id,UpdateContactRequest updateContactRequest)
        {
            var  contact =await DbContext.Contacts.FindAsync(id);

            if (contact != null)
            {
                contact.Name    = updateContactRequest.Name;
                contact.Email   = updateContactRequest.Email;
                contact.Phone   = updateContactRequest.Phone;
                contact.Address = updateContactRequest.Address;
                contact.City    = updateContactRequest.City;
                contact.Country = updateContactRequest.Country;



             
                await DbContext.SaveChangesAsync();


                return Ok(contact);

            }
            


            return NotFound();
;
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DelectContadByID([FromRoute] Guid id)
        {

            var contact = await DbContext.Contacts.FindAsync(id);

            if (contact != null)
            {
                DbContext.Contacts.Remove(contact);
                await DbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound("This not found");

        }

    }
}
