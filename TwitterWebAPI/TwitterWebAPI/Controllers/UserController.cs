using Microsoft.AspNetCore.Mvc;
using TwitterWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TwitterWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>

        public List<User> users = new List<User>();
        public UserController()
        {
            users.Add(new User("Adrian", "adrian", "23112")); // Sample user added for demonstration
            users.Add(new User("Adrian", "adrian", "23112")); // Sample user added for demonstration
            users.Add(new User("Adrian", "adrian", "23112")); // Sample user added for demonstration
            users.Add(new User("Adrian", "adrian", "23112")); // Sample user added for demonstration
            users.Add(new User("Adrian", "adrian", "23112")); // Sample user added for demonstration

        }
        [HttpGet]
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(users);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
