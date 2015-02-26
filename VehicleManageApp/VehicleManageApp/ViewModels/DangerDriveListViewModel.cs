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
	public class DangerDriveListViewModel : BaseViewModel
	{
		private static int count = 0;

		public DangerDriveListViewModel ()
		{
			//var _dangerDriveService = new DanDriveService();
			//var result = await _dangerDriveService.GetDangerDriveList();
			DangerDriveList = new NotifyTaskCompletion<List<DangerDriveViewModel>> (GetDangerDriveList (""));

			this.SearchBarCommand = new Command (async (nothing) => {
				DangerDriveList = new NotifyTaskCompletion<List<DangerDriveViewModel>> (GetDangerDriveList (keyValues));

//					var result = await _loginService.LoginAsync(Username, Password);
//					if (result.USER_ID > 0)
//					{
//
//						Application.Current.Properties["USER_ID"] = result.USER_ID;
//
//						//await Navigation.PushAsync(new MainPage());
//					}
//					else
//					{
//						//await Navigation.DisplayAlert("错误", "输入的用户名或密码错误！", "确定");
//					}

			});
		}

		//		private async Task<List<DangerDriveViewModel>> GetDangerDriveList ()
		//		{
		//			var _dangerDriveService = new DanDriveService ();
		//			var result = await _dangerDriveService.GetDangerDriveList ("");
		//			return result.Select (n => new DangerDriveViewModel (n)).ToList ();
		//			//return result;
		//		}

		private async Task<List<DangerDriveViewModel>> GetDangerDriveList (string keyValues)
		{
			var _dangerDriveService = new DanDriveService ();
			var result = await _dangerDriveService.GetDangerDriveList (keyValues);
			return result.Select (n => new DangerDriveViewModel (n)).ToList ();
			//return result;
		}

		public NotifyTaskCompletion<List<DangerDriveViewModel>> DangerDriveList { get; private set; }

		private string _keyValues;

		public string keyValues { 
			get { 
				return string.IsNullOrEmpty (_keyValues) ? _keyValues : _keyValues.ToUpper (); 
			} 
			set { 
				_keyValues = value.ToUpper (); 
			} 
		}

		public ICommand SearchBarCommand { private set; get; }
	}
}
