﻿using ContactList.Entities;
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
    }
}
