using System;

namespace WpfStrategy.Category
{
	public class TvProduct : ITechnicCategory
	{
		private readonly decimal _pricePerDay;
		private readonly decimal _exportPrice;

		public TvProduct()
		{
			_pricePerDay = 2.5m;
			_exportPrice = 5;
		}

		public decimal GetPrice( TimeSpan duration )
		{
			return duration.Days * _pricePerDay + _exportPrice;
		}

		public string GetPriceDescription()
		{
			return $"Price per day: {_pricePerDay}$ + export price {_exportPrice}$";
		}

		public override string ToString()
		{
			return "TV";
		}
	}
}
