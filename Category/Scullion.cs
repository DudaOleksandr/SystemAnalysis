using System;

namespace WpfStrategy.Category
{
    public class Scullion: ITechnicCategory
    {
        private readonly decimal _pricePerDay;
        private readonly decimal _exportPrice;

        public Scullion()
        {
            _pricePerDay = 5.4m;
            _exportPrice = 10;
        }
        public decimal GetPrice(TimeSpan duration)
        {
            return duration.Days * _pricePerDay + _exportPrice;
        }

        public string GetPriceDescription()
        {
            return $"Price per day: {_pricePerDay}$ + export price {_exportPrice}$";
        }

        public override string ToString()
        {
            return "Scullion";
        }
    }
}