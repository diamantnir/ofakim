using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Currencies.Models;
using Currencies.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Currencies
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly IVendor _xe = new XE();
        ReadUpBooksContext dbContext = new ReadUpBooksContext();

        public CurrencyController(IVendor xe)
        {
            _xe = xe;
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> Post(string from,string to)
        {
            _xe.from = from;
            _xe.to = to;
           string res = await _xe.GetData();

            return Ok();

        }


        [HttpGet("[action]")]
        public IEnumerable<CurrenciesDetails> Get()
        {
            List<CurrenciesDetails> currencies = dbContext.CurrenciesDetails.GroupBy(x => new { x.From, x.To }, (key, g) => g.OrderBy(e => e.Date).First()).ToList();
            return currencies;
        }

    }
}