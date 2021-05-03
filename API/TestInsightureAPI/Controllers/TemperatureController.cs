using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Temprature.Commands;
using TestInsightureAPI.Controllers.Base;

namespace TestInsightureAPI.Controllers
{ 

    public class TemperatureController : BaseController
    {      

        [HttpPost("ConvertTemperature")]
        public async Task<ActionResult<TemperatureModel>> ConvertTemperature(ConvertTemperatureValueCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}