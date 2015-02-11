using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManageApp.ViewModels;
using VehicleManageApp.Model;

namespace VehicleManageApp.Services
{
    public interface IDanDriveService
    {
        Task<List<DangerDrive>> GetDangerDriveList();
    }
}
