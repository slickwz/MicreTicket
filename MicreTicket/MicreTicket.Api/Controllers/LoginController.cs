using MicreTicket.Application;
using MicreTicket.Common;
using MicreTicket.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MicreTicket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private LoginService service;
        public LoginController(LoginService service)
        {
            this.service = service;
        }
        // GET: api/Login
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        [HttpPost]
        public CallResult Post([FromBody] LoginDTO dto)
        {

            return new CallResult();
        }

        // PUT: api/Login/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
