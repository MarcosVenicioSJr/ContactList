using ContactList.Entities;
using ContactList.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactList.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Contact> contacts = _contactService.GetAll();
            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Contact contact = _contactService.Get(id);
            return Ok(contact);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Contact contact)
        {
            _contactService.Create(contact);
            return Created();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _contactService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Contact contact)
        {
            _contactService.Update(contact);
            return Ok();
        }
    }
}
