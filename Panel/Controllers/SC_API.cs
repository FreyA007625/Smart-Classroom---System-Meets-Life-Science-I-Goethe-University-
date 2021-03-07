using Microsoft.AspNetCore.Mvc;
using SmartClassRoom_Panel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartClassRoom_Panel.Controllers
{
    [Route("api")]
    [ApiController]
    public class SC_API : ControllerBase
    {
        // GET: api/<SC_API>
        [HttpGet]
        public IEnumerable<Classroom> Get()
        {
            SC_Context context = HttpContext.RequestServices.GetService(typeof(SmartClassRoom_Panel.Models.SC_Context)) as SC_Context;
            var ent = context.GetAllClassrooms();
            return ent;
        }

        // GET api/<SC_API>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SC_API>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SC_API>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SC_API>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
