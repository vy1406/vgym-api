using Microsoft.AspNetCore.Mvc;
using Vgym.Server.Services;
using Vgym.Server.Utilities;



namespace Vgym.Server.Controllers
{
    //Example boilerplate for a controller that implaments CRUD oparations
    
    [Route("api/[controller]")]
    [ApiController]
    public class DummyController : ControllerBase
    {
        //A dependency injection of a service 
        private readonly IDummyService _dummyService;

        public DummyController(IDummyService dummyService)
        {
                _dummyService=dummyService;
        }

        //Example for endpoint:
        // GET: api/<DummyController>
        [HttpGet]
        public IActionResult Get()
        {
            //Example of a test response
            var response = new
            {
                ErrorCode= ErrorCodes.NO_ERROR,
                ErrorMessage= "message from get",
                Body="body from get action"
            };
            return Ok(response);
        }
        //Example for endpoint:
        // GET api/<DummyController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = new
            {
                ErrorCode = ErrorCodes.NO_ERROR,
                ErrorMessage = "message from get with id",
                Body = $"value of id is : {id}"
            };
            return Ok(response);
        }
        //Example for endpoint:
        // POST api/<DummyController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            var response = new
            {
                ErrorCode = ErrorCodes.NO_ERROR,
                ErrorMessage = "message from post",
                Body = $"the value that was passed with this request is : {value}"
            };
            return Ok(response);
        }
        //Example for endpoint:
        // PUT api/<DummyController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            var response = new
            {
                ErrorCode = ErrorCodes.NO_ERROR,
                ErrorMessage = "message from put",
                Body = $"the id to update is : {id} and the value is:  {value}"
            };
            return Ok(response);
        }
        //Example for endpoint:
        // DELETE api/<DummyController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = new
            {
                ErrorCode = ErrorCodes.NO_ERROR,
                ErrorMessage = "message from delete",
                Body = $"the id to be deleted is : {id}"
            };
            return Ok(response);
        }
    }
}
