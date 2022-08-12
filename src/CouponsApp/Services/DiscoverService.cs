using CouponsApp.Models;

namespace CouponsApp.Services
{
    public class DiscoverService
    {
        static DiscoverService _instance;

        public static DiscoverService Instance
        {
            get
            {
                _instance ??= new DiscoverService();

                return _instance;
            }
        }

        public List<Discover> GetDiscover()
        {
            return new List<Discover>
            {
                new Discover { Title = "Most Favourites", CouponsCount = 28, Color = Color.FromArgb("#FFEAA833") },

                new Discover { Title = "Newest", CouponsCount = 20, Color = Color.FromArgb("#FF40BAF6") },

                new Discover { Title = "Supermarkets", CouponsCount = 56, Color = Color.FromArgb("#FFA7D5F8") },
            };
        }
    }
}
