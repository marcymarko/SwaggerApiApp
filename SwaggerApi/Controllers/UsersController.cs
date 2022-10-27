using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwaggerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    // GET: api/Users
    /// <summary>
    /// This gets a list of all users in the system.
    /// </summary>
    /// <remarks>
    /// Sample Request: GET /Users
    /// Sample Response:
    /// [
    ///     {
    ///         "id": 1,
    ///         "name": "Mark Zilkovskyi"
    ///     },
    ///     {
    ///         "id": 2,
    ///         "name": "Fil Zilkovskyi"
    ///     }
    /// ]
    /// </remarks>
    /// <returns>A list of users</returns>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/Users/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/Users
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Users/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Users/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
