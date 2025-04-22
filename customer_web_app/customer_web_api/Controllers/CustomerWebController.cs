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
           var featuresPromos = _context.FeaturesPromos.ToList();
            if(featuresPromos != null)
            {
                if(featuresPromos.Count > 0)
                {
                    return featuresPromos;
                }
                else if (featuresPromos.Count == 0)
                {
                    return new List<FeaturesPromos>();
                }
            }
            else
            {
                return new List<FeaturesPromos>();
            }
            return new List<FeaturesPromos>();
        }

        [HttpGet,Route("GetValue")]
        public List<CardDetails> GetCardDetails()
        {
            return _context.CardDetails.ToList();
        }
    }
}
