using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Add_Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingNumbersController : ControllerBase
    {

        private readonly ILogger<AddingNumbersController> _logger;

        public AddingNumbersController(ILogger<AddingNumbersController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public int Post(int number, int addend)
        {
            return number + addend;
        }

        [HttpGet]
        public int Get()
        {
            return 10 + 20;
        }
    }
}
