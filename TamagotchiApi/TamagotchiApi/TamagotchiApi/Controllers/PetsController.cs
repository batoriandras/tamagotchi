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
        // GET api/<PetsController>
        [HttpGet("/pets/{id}")]
        public Model.Pet GetCity(ulong id)
        {
            return data.Pets.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] Model.Pet retval)
        {
            data.Pets.Add(retval);
            data.SaveChanges();
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public void Delete(ulong id)
        {
            data.Pets.Remove(data.Pets.Find(id));
            data.SaveChanges();
        }
    }
}
