using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManageApp.ViewModels;

namespace VehicleManageApp.Services
{
    public interface ILoginService
    {
        Task<LoginViewModel> LoginAsync(string username, string password);
    }
}
