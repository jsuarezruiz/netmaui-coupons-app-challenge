using CouponsApp.Models;

namespace CouponsApp.Services
{
    public class CouponService
    {
        static CouponService _instance;

        public static CouponService Instance
        {
            get
            {
                _instance ??= new CouponService();

                return _instance;
            }
        }

        public List<Coupon> GetCoupons()
        {
            return new List<Coupon>
            {
                new Coupon
                {
                    Id = 1,
                    Title = "McDonald's french",
                    Discount= -5.00,
                    CompanyLogo = "McDonalds.png",
                    Image = "Chips.png",
                    Color =  Color.FromArgb("#FF4AA596")
                },

                new Coupon
                {
                    Id = 2,
                    Title = "Donuts",
                    Discount= -0.50,
                    CompanyLogo = "DunkinDonuts.png",
                    Image = "Donut.png",
                    Color = Color.FromArgb("#FFE0E7F8"),
                },

                new Coupon
                {
                    Id = 3,
                    Title= "Pizza",
                    Discount = -1.25,
                    CompanyLogo = "Domino.png",
                    Image = "Pizza.png",
                    Color = Color.FromArgb("#FFE5E3F2"),
                },

                new Coupon
                {
                    Id = 4,
                    Title="iPhone",
                    Discount= -15,
                    CompanyLogo = "Apple.png",
                    Image= "iPhone.png",
                    Color= Color.FromArgb("#FFD7E2F1"),
                },

                new Coupon
                {
                    Id = 5,
                    Title = "Cappuccino",
                    Discount = -10,
                    CompanyLogo = "Starbucks.png",
                    Image = "Coffee.png",
                    Color = Color.FromArgb("#FFEFE9EB")
                },

                new Coupon
                {
                    Id = 6,
                    Title = "Shoes",
                    Discount = -30,
                    CompanyLogo = "Adidas.png",
                    Image = "Shoes.png",
                    Color = Color.FromArgb("#FFEBE9F1")
                },

                new Coupon
                {
                    Id = 7,
                    Title = "Electric toothbrush",
                    Discount = -18,
                    CompanyLogo = "Goby.png",
                    Image = "Toothbrush.png",
                    Color = Color.FromArgb("#FFEDDCEE")
                },

                new Coupon
                {
                    Id = 8,
                    Title = "Game Consoles",
                    Discount = -10,
                    CompanyLogo = "Sony.png",
                    Image = "PS5.png",
                    Color = Color.FromArgb("#FF191879")
                },
            };
        }
    }
}