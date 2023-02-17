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
    public class PetsController : ControllerBase
    {
        Model.laravelContext data = new Model.laravelContext();

        // GET api/<PetsController>
        [HttpGet("/pets")]
        public IEnumerable<Model.Pet> GetAllPets()
        {
            return data.Pets;
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
