using GL.WebApi.DTO.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GL.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private ISimpleCalculator service;

        public CalculatorController(ISimpleCalculator service)
        {
            this.service = service;
        }

        [HttpGet("add/start/{start}/amount/{amount}")]
        public async Task<int> AddAsync([FromRoute] int start, [FromRoute] int amount)
        {
            return await Task.FromResult(service.Add(start, amount));
        }

        [HttpGet("subtract/start/{start}/amount/{amount}")]
        public async Task<int> SubtractAsync([FromRoute] int start, [FromRoute] int amount)
        {
            return await Task.FromResult(service.Subtract(start, amount));
        }
    }
}
