using System;

namespace WpfStrategy.Category
{
	class Refrigerator : ITechnicCategory
	{
		private readonly decimal _pricePerDay;
		private readonly decimal _exportPrice;

		public Refrigerator()
		{
			_pricePerDay = 8m;
			_exportPrice = 25;
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
			return "Refrigerator";
		}
	}
}
