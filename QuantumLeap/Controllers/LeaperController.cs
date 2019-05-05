using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantumLeap.Data;

namespace QuantumLeap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaperController : ControllerBase
    {
        readonly LeaperRepository _leaperRepository;

        public LeaperController()
        {
            _leaperRepository = new LeaperRepository();
        }

        [HttpGet]
        public ActionResult GetAllLeapers()
        {
            var leapers = _leaperRepository.GetAllLeapers();

            return Ok(leapers);
        }
    
    }
}