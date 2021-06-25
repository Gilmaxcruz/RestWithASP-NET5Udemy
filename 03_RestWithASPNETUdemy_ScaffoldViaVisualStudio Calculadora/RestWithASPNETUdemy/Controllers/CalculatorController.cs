using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Iservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        private ICalculatorService _calculatorService;

        public CalculatorController(ILogger<CalculatorController> logger, ICalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;

        }

        [HttpGet("Soma/{firsNumber}/{secundNumber}")]
        public IActionResult GetSoma(string firsNumber, string secundNumber)
        {
            string soma = _calculatorService.Somar(firsNumber, secundNumber);
            if (string.IsNullOrWhiteSpace(soma))
            {
                return BadRequest("Invalid Input");
            }
            return Ok(soma);
        }

        [HttpGet("Subtracao/{firsNumber}/{secundNumber}")]
        public IActionResult GetSubtracao(string firsNumber, string secundNumber)
        {
            string Subtracao = _calculatorService.Subtracao(firsNumber, secundNumber);
            if (string.IsNullOrWhiteSpace(Subtracao))
            {
                return BadRequest("Invalid Input");
            }
            return Ok(Subtracao);
        }

        [HttpGet("Multiplicacao/{firsNumber}/{secundNumber}")]
        public IActionResult GetMultiplicacao(string firsNumber, string secundNumber)
        {
            string Subtracao = _calculatorService.Multiplicacao(firsNumber, secundNumber);
            if (string.IsNullOrWhiteSpace(Subtracao))
            {
                return BadRequest("Invalid Input");
            }
            return Ok(Subtracao);
        }

        [HttpGet("Divisao/{firsNumber}/{secundNumber}")]
        public IActionResult GetDivisao(string firsNumber, string secundNumber)
        {
            string Subtracao = _calculatorService.Divisao(firsNumber, secundNumber);
            if (string.IsNullOrWhiteSpace(Subtracao))
            {
                return BadRequest("Invalid Input");
            }
            return Ok(Subtracao);
        }




    }
}
