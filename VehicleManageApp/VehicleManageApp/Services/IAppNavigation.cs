using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManageApp.Services
{
    public interface IAppNavigation
    {
        Task LoggedIn(bool result);

        Task ShowAbout();

        Task ShowLogin();

        //Task ShowProduct(Product product);

        //Task ShowProductList(List<Product> items, string title, bool canShowSinglePage = false);
    }
}
