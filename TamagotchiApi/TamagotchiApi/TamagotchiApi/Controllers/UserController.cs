using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TamagotchiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        Model.laravelContext data = new Model.laravelContext();
        // GET api/<PetsController>
        [HttpGet("/users")]
        public IEnumerable<Model.UsersDatum> GetAllUsers()
        {
            return data.UsersData;
        }

        // GET api/<PetsController>
        [HttpGet("/users/{id}")]
        public IEnumerable<Model.UsersDatum> GetUserById(int id)
        {
            return data.UsersData.FirstOrDefault(x=>x.Id == id);
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
