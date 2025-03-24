using customer_web_api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace customer_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerWebController : ControllerBase
    {
        private readonly CustomerWebContext _context;
        public CustomerWebController(CustomerWebContext context) 
        {
            _context = context;
        }
        [HttpGet,Route("GetPromos")]
        public List<FeaturesPromos> GetPromos()
        {
           return _context.FeaturesPromos.ToList();
        }

        [HttpGet,Route("GetValue")]
        public List<CardDetails> GetCardDetails()
        {
            return _context.CardDetails.ToList();
        }
    }
}
