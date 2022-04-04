using CRI.Core;
using Microsoft.AspNetCore.Mvc;

namespace CRI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarRegistryController : Controller
    {
        private ICarRegistryInfo _service;

        public CarRegistryController(ICarRegistryInfo carRegistry)
        {
            _service = carRegistry;
        }


        [HttpGet("ValidateNumberPlate")]
        public bool validateNumberPalte([FromQuery] string numberPlate)
        {

            return _service.validateNumberPlate(numberPlate);
        }


    }
}
