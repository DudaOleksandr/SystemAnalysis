using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using WpfStrategy.Category;

namespace WpfStrategy
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
		
		public IList<ITechnicCategory> Categories { get; private set; }

		public MainWindowViewModel()
		{
			Categories = new List<ITechnicCategory> {new TvProduct(), new Refrigerator(), new Scullion()};
			From = DateTime.Today;
			To = DateTime.Today;
			Category = Categories.First();
		}

		private DateTime _from;
		public DateTime From
		{
			get => _from;
			set
			{
				_from = value;
				OnPropertyChanged("From");
				OnPropertyChanged("CalculatedPrice");
			}
		}

		private DateTime _to;
		public DateTime To
		{
			get => _to;
			set
			{
				_to = value;
				OnPropertyChanged("CalculatedPrice");
			}
		}

		private ITechnicCategory _category;
		public ITechnicCategory Category
		{
			get => _category;
			set
			{
				_category = value;
				OnPropertyChanged("CalculatedPrice");
				OnPropertyChanged("CalculatedPriceFor1Day");
			}
		}

		public DateTime Today => DateTime.Today;

		public string CalculatedPrice => Category.GetPrice(To.AddDays(1) - From) + " $";
		
		public string CalculatedPriceFor1Day => Category.GetPriceDescription();

		#region OnPropertyChanged implementation

		private void OnPropertyChanged(string prop)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion
		
	}
}
