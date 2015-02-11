using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace VehicleManageApp.Views
{
    public partial class WelcomePage : ContentPage
    {
        private INavigation _navi;
        public WelcomePage()
        {
            InitializeComponent();
        }



        public void OnButtonClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new LoginPage());
            //new Command<Type>(async (Type pageType) =>
            //{
            //    //Page page = (Page)Activator.CreateInstance(pageType);
            //    await this.Navigation.PushAsync(new LoginPage());
            //});
            //var client = new HttpClient();
            //client.BaseAddress= new Uri("http://cloud.tescar.cn/home/");
            //var response = client.GetAsync("LoginSubmit2?UserName=admin&Pwd=123&isspe=1");
            //var loginJson = response.Con

        }
    }
}
