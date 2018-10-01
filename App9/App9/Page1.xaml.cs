using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App9
{
	
	public partial class Page1 : MasterDetailPage
	{
		public Page1 ()
		{
			InitializeComponent ();
			ListView1.ItemsSource = new string[]
				{
					"MY ACCOUNT",
					"SHOP",
					"FAQ",
					"NOTIFICATIONS"

			};
			Detail=new Page2();
		}

		private void ListView1_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (ListView1.SelectedItem.Equals("MY ACCOUNT"))
			{
				Detail=new Page2();
				IsPresented = false;
			}
			else if (ListView1.SelectedItem.Equals("SHOP"))
			{
				Detail = new shop();
				IsPresented = false;
			}
			else if (ListView1.SelectedItem.Equals("FAQ"))
			{
				Detail = new Page3();
				IsPresented = false;
			}
			else if (ListView1.SelectedItem.Equals("NOTIFICATIONS"))
			{
				Detail = new Page4();
				IsPresented = false;
			}
		}
	}
}