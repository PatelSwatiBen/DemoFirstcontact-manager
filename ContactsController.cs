using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContactManagerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private static List<Contact> contacts = new List<Contact>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(contacts);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            contacts.Add(contact);
            return Ok(contact);
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}