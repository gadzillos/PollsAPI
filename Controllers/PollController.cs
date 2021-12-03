using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PollsAPI.Common;
using PollsAPI.DAL.Domain;
using PollsAPI.DAL.MemoryStorage;


namespace PollsAPI.Controllers
{
    [ApiController]
    [Route("api/{controller}/{action}/{id?}")]
    public class PollController : ControllerBase
    {
        private readonly ILogger<PollController> _logger;
        private readonly IPollStorage _pollStorage;

        public PollController(ILogger<PollController> logger, IPollStorage pollStorage)
        {
            _logger = logger;
            _pollStorage = pollStorage;
        }

        [HttpPut]
        public IActionResult Create([FromBody]object pollContract)
        {
            DTO.PollCreationContract contract = JsonConvert.DeserializeObject<DTO.PollCreationContract>(pollContract.ToString());

            string authHeader = this.HttpContext.Request.Headers["Authorization"];

            if (!BasicAuthorization.CheckHeader(authHeader))
            {
                return Unauthorized("Authorization error");
            }

            try
            {
                (string username, string password) = BasicAuthorization.GetCredentials(authHeader);
            }
            catch (Exception)
            {
                return Unauthorized("Authorization error");
            }

            
            throw new NotImplementedException(); // Json was painful
        }

        [HttpPatch]
        public IActionResult Publish()
        {
            throw new NotImplementedException();
        }

        [HttpPatch]
        public IActionResult Complete()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public IActionResult Vote()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public JsonResult Report()
        {
            throw new NotImplementedException();
        }
    }
}
