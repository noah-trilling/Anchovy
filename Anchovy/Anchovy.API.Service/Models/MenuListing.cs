namespace Anchovy.API.Service.Models
{
    public class MenuListing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public decimal Cost { get; set; }
    }
}