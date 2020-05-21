using MicroServiceExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MicroServiceExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        // GET: Person
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return PersonStorage.Instance.Persons.ToArray();
        }

        // GET: Person/5
        [HttpGet("{id}", Name = "Get")]
        public Person Get(int id)
        {
            return PersonStorage.Instance.Find(id);
        }

        // POST: Person
        [HttpPost]
        public void Post([FromBody] Person value)
        {
            PersonStorage.Instance.Add(value);
        }

        // PUT: Person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person value)
        {
            PersonStorage.Instance.Update(id, value);
        }

        // DELETE: ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PersonStorage.Instance.Delete(id);
        }
    }
}
