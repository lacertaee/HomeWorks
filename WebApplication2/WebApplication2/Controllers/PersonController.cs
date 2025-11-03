using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Validations;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        public List<Person> persons = new List<Person>
        {
            new Person
            {
                Id = 1,
                CreateDate = DateTime.Now,
                FirstName = "John",
                LastName = "Doe",
                JobPosition = "Developer",
                Salary = 5000,
                WorkExperience = 3,
                PersonAddress = new Address
                {
                    Country = "Georgia",
                    City = "Tbilisi",
                    HomeNumber = 123456,
                }
            }
        };

        [HttpPost("addPerson")]
        public IActionResult AddPerson([FromBody] Person person)
        {
            var validator = new PersonValidator();

            var result = validator.Validate(person);

            if (!result.IsValid)
            {
                var errors = result.Errors.Select(error => error.ErrorMessage).ToList();
                return BadRequest(errors);
            }

            persons.Add(person);
            return Ok(persons);
        }

        [HttpGet("persons")]
        public IActionResult GetPersons()
        {
            return Ok(persons);
        }

        [HttpGet("persons/{id}")]

        public IActionResult GetPerson(int id)
        {
            var person = persons.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                return NotFound("Person with this id doesn't exist");
            }
            return Ok(person);
        }

        [HttpGet("filterPersons")]

        public IActionResult SearchPersons([FromQuery] FilterPerson filter)
        {
            var filtered = persons.Where(p => p.Salary > filter.Salary).ToList();
            return Ok(filtered);
        }

        [HttpDelete("persons/{id}")]

        public IActionResult DeletePerson(int id)
        {
            var person = persons.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                return NotFound("Person with this id doesn't exist");
            }

            persons.Remove(person);

            return Ok(persons);
        }

        [HttpPut("persons/{id}")]
        public IActionResult UpdatePerson([FromBody] Person person, int id)
        {
            var getPerson = persons.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                return NotFound("Person with this id doesn't exist");
            }

            getPerson.FirstName = person.FirstName;
            getPerson.Salary = person.Salary;

            return Ok(getPerson);

        }

    }
}
