using System.ComponentModel.DataAnnotations;

namespace customer_web_api.Entities
{
    public class FeaturesPromos
    {
        [Key]
        public int Id { get; set; }
        //head content for the promos
        public string Head { get; set; }
        //body content for the promos
        public string Body { get; set; }
        //foot content for the promos
        public string Foot { get; set; }
    }
}
