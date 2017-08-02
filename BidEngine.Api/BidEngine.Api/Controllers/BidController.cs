using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BidEngine.Api.Interfaces.Managers;
using BidEngine.Api.Types;
using Microsoft.AspNetCore.Mvc;

namespace BidEngine.Api.Controllers
{
    [Route("api/[controller]")]
    public class BidController : Controller
    {
        private IBidManager _bidManager;

        public BidController(IBidManager bidManager)
        {
            _bidManager = bidManager;
        }

        // GET api/values
        [HttpGet]
        public List<Bid> Get()
        {
            return _bidManager.GetCurrentBids();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
