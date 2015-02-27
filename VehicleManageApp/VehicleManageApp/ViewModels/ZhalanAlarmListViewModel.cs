using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManageApp.Async;
using VehicleManageApp.Services;
using System.Windows.Input;
using VehicleManageApp.Mvvm;
using Xamarin.Forms;

namespace VehicleManageApp.ViewModels
{
	public class ZhalanAlarmListViewModel : BaseViewModel
	{

		public ZhalanAlarmListViewModel ()
		{		
			//TaskDangerDriveList = new NotifyTaskCompletion<List<DangerDriveViewModel>> (GetDangerDriveList (""));
			//DangerDriveList = (new NotifyTaskCompletion<List<DangerDriveViewModel>> (GetDangerDriveList (""))).Result;

			Firstload ();
			this.SearchBarCommand = new Command (async (nothing) => {
				DangerDriveList = await GetDangerDriveList (keyValues);

			});
		}

		private async void Firstload ()
		{
			DangerDriveList = await GetDangerDriveList ("");
		}

		private async Task<List<DangerDriveViewModel>> GetDangerDriveList (string keyValues)
		{
			var _dangerDriveService = new DanDriveService ();
			var result = await _dangerDriveService.GetDangerDriveList (keyValues);
			return result.Select (n => new DangerDriveViewModel (n)).ToList ();
			//return result;
		}

		public NotifyTaskCompletion<List<DangerDriveViewModel>> TaskDangerDriveList { get; private set; }

		public List<DangerDriveViewModel> DangerDriveList { 
			get { return GetValue<List<DangerDriveViewModel>> (); } 
			set { SetValue (value); } 
		}

		public string keyValues { 
			get { 
				return GetValue<string> ();
			} 
			set { 
				SetValue (value);
			} 
		}

		public ICommand SearchBarCommand { private set; get; }
	}
}
