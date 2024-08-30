using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecapWebAPI_BLL.Interface;

namespace RecapWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_playerService.GetAll()); 
        }
    }
}
