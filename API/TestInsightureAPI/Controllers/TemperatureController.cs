using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Temprature.Queries;
using TestInsightureAPI.Controllers.Base;

namespace TestInsightureAPI.Controllers
{ 
    public class TemperatureController : BaseController
    {
        [HttpGet("GetTemperatureValues/{type}/{tempValue}")]
        public async Task<ActionResult<TemperatureModel>> GetTemperatureValues(int type, string tempValue)
        {
            var result = await Mediator.Send(new GetTemperatureValuesQuery() { TempValue = tempValue, Type = (TemperatureTypeEnum)type});
            return Ok(result);
        }
       
    }
}