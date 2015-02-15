using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleManageApp.ViewModels;
using VehicleManageApp.Views;
using Xamarin.Forms;

namespace VehicleManageApp
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application			
			RegisterTypes ();
            
			var id = 0;
			if (Application.Current.Properties.ContainsKey ("USER_ID")) {
				id = (int)Application.Current.Properties ["USER_ID"];
				// do something with id
			}

			//MainPage = id > 0 ? new NavigationPage(new MainPage()) : new NavigationPage(ViewFactory.CreatePage<LoginViewModel>());
			#region testcase

			MainPage = new NavigationPage (new MainPage ());
			//MainPage = new NavigationPage(new TestPage());

			#endregion
		}

		static void RegisterTypes ()
		{
			// This can be replaced by any number of MVVM tools. It is done this way merely because this 
			// is not intended to be a demo of those tools.
			ViewFactory.Register<LoginPage, LoginViewModel> ();
			//ViewFactory.Register<DangerDriveList, DangerDriveListViewModel> ();
			ViewFactory.Register<DangerDriveSingleList, DangerDriveListViewModel> ();
			//ViewFactory.Register<TodoItemPage, TodoItemViewModel>();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

		public static Page LoginPage { get; private set; }

		public static WelcomeViewModel WelcomeViewModel { get; set; }

		public static LoginViewModel LoginViewModel{ get; set; }

		public static HomePageViewModel HomePageViewModel { get; set; }
	}
}
