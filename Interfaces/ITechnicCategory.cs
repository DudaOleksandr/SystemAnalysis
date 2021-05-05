using System;

namespace WpfStrategy.Category
{
	public interface ITechnicCategory
	{
		decimal GetPrice(TimeSpan duration);
		string GetPriceDescription();
	}
}
