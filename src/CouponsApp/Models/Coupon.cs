namespace CouponsApp.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public double Discount { get; set; }
        public Color Color { get; set; }
        public string Image { get; set; }
        public string CompanyLogo { get; set; }
    }
}