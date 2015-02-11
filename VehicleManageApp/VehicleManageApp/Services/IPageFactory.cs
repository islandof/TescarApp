using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VehicleManageApp.Services
{
    public enum Pages
    {
        Login,
        Welcome,
        Categories,
        About,
    }

    public interface IPageFactory
    {
        Page GetPage(Pages page);
    }
}
