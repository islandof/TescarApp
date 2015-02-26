using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManageApp.ViewModels;
using Xamarin.Forms;

namespace VehicleManageApp.Views
{
	public partial class MonitorCentre : ContentPage
	{
		public MonitorCentre ()
		{
			InitializeComponent ();
		}

		private void Button_OnClicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (ViewFactory.CreatePage<DangerDriveListViewModel> ());
		}

		private void Alert_OnClicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new ListViewDemoPage ());
		}

		private void Locate_OnClicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new DangerDriveSinglePage ());
		}

	}
}
