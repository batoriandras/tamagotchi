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
    public class AnimalController : ControllerBase
    {
        Model.laravelContext data = new Model.laravelContext();
        // GET: api/<AnimalController>
        [HttpGet("/animals")]
        public IEnumerable<Model.Animal> GetAllanimals()
        {
            return data.Animals;
        }

        // GET api/<AnimalController>/5
        [HttpGet("/animals/{id}")]
        public Model.Animal GetAnimalById(ulong id)
        {
            return data.Animals.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<AnimalController>
        [HttpPost]
        public void Post([FromBody] Model.Animal retval)
        {
            data.Animals.Add(retval);
            data.SaveChanges();
        }

        // PUT api/<AnimalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnimalController>/5
        [HttpDelete("{id}")]
        public void Delete(ulong id)
        {
            data.Animals.Remove(data.Animals.Find(id));
            data.SaveChanges();
        }
    }
}
