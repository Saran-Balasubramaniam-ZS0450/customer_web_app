using System.ComponentModel.DataAnnotations;

namespace customer_web_api.Entities
{
    public class CardDetails
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get;set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string OriginalPrice { get; set; }
        public string DiscountPrice { get; set; } = string.Empty;
    }
}
