using CouponsApp.Models;
using CouponsApp.Services;
using System.Collections.ObjectModel;

namespace CouponsApp.ViewModels
{
    public class CouponsViewModel : BindableObject
    {
        ObservableCollection<Coupon> _coupons;
        ObservableCollection<Discover> _discover;

        public CouponsViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Coupon> Coupons
        {
            get { return _coupons; }
            set
            {
                _coupons = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Discover> Discover
        {
            get { return _discover; }
            set
            {
                _discover = value;
                OnPropertyChanged();
            }
        }

        void LoadData()
        {
            Coupons = new ObservableCollection<Coupon>(CouponService.Instance.GetCoupons());
            Discover = new ObservableCollection<Discover>(DiscoverService.Instance.GetDiscover());
        }
    }
}
