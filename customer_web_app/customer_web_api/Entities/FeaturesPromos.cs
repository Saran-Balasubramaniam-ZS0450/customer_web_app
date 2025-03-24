using System.ComponentModel.DataAnnotations;

namespace customer_web_api.Entities
{
    public class FeaturesPromos
    {
        [Key]
        public int Id { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public string Foot { get; set; }
    }
}
