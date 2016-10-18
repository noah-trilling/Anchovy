namespace Anchovy.API.Service.Models
{
    public class Line
    {
        public int Id { get; set; }
        public int MenuListingId { get; set; }
        public MenuListing MenuListing { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int Quantity { get; set; }
    }
}