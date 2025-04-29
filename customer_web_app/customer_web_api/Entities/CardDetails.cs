using System.ComponentModel.DataAnnotations;

namespace customer_web_api.Entities
{
    public class CardDetails
    {
        [Key]
        public int Id { get; set; }
        //title for the card
        public string Title { get; set; }
        //subtitle for the card
        public string SubTitle { get;set; }
        //description for the card
        public string Description { get; set; }
        //weight for the card
        public string Weight { get; set; }
        //original price for the card   
        public string OriginalPrice { get; set; }
        //discount price for the card
        public string DiscountPrice { get; set; } = string.Empty;
    }
}
