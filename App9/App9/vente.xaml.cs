using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App9
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class vente : ContentPage
	{
		private List<Gucci> tempdata;

		//List<string> venteList=new List<string> {"MY ACCOUNT",
		//	"SHOP",
		//	"FAQ",
		//	"NOTIFICATIONS"

		//};


		public vente ()
		{
			InitializeComponent ();
			//ListViewVente.ItemsSource = venteList;

			tempdata = new List<Gucci>
			{
				new Gucci{ Name ="Gucci Quilty",Status = "Almost New", Image = "bag.jpg", Price = "3000.00 SAR"},
				new Gucci{ Name ="Gucci Hand Bag Light Brown",Status = "Almost New", Image = "bag1.jpg", Price = "3000.00 SAR"},
				new Gucci{ Name ="Gucci Hand Bag Light Brown",Status = "Almost New", Image = "bag3.jpg", Price = "3000.00 SAR"}
		    };

			ListViewVente.ItemsSource = tempdata;
		}

		//private void SearchBar_OnSearchButtonPressed(object sender, EventArgs e)
		//{
		//	var keyword = MainSearchBar.Text;
		//	ListViewVente.ItemsSource = venteList.Where(name => name.Contains(keyword));
		//}
	

		private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
		{
			ListViewVente.BeginRefresh();

			if (string.IsNullOrWhiteSpace(e.NewTextValue))
			{
				ListViewVente.ItemsSource = tempdata;
			}

			else
			{
				ListViewVente.ItemsSource = tempdata.Where(x => x.Name.StartsWith(e.NewTextValue));
			}

			ListViewVente.EndRefresh();
		}

		//private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
		//{
			
		//}
	}
}