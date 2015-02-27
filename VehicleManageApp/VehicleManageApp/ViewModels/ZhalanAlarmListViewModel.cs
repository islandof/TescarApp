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
				ZhalanAlarmList = await GetData (keyValues);

			});
		}

		private async void Firstload ()
		{
			ZhalanAlarmList = await GetData ("");
		}

		private async Task<List<ZhalanAlarmViewModel>> GetData (string keyValues)
		{
			var _service = new ZhalanAlarmService ();
			var result = await _service.GetZhalanAlarmList (keyValues);
			return result.Select (n => new ZhalanAlarmViewModel (n)).ToList ();
			//return result;
		}


		public List<ZhalanAlarmViewModel> ZhalanAlarmList { 
			get { return GetValue<List<ZhalanAlarmViewModel>> (); } 
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
