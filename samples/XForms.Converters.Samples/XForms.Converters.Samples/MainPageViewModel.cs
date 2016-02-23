using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XForms.Converters.Samples
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		private string _itemName = "XForms!!";
		private bool _isEnabled = true;

		public string ItemName
		{
			get { return _itemName; }
			set
			{
				_itemName = value;
				OnPropertyChanged();
			}
		}
		public bool IsEnabled
		{
			get { return _isEnabled; }
			set
			{
				_isEnabled = value;
				OnPropertyChanged();
			}
		}

		public ObservableCollection<string> Items { get; private set; }
		public ICommand AddItemCommand { get; private set; }

		public MainPageViewModel()
		{
			Items = new ObservableCollection<string>();
			AddItemCommand = new Command(AddItem);
		}

		private void AddItem()
		{
			Items.Add(ItemName);
			ItemName = string.Empty;
		}


		public event PropertyChangedEventHandler PropertyChanged;

		
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
