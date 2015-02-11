using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManageApp.Async;
using VehicleManageApp.Services;

namespace VehicleManageApp.ViewModels
{
    public class DangerDriveListViewModel : BaseViewModel
    {
        private static int count = 0;
        public DangerDriveListViewModel()
        {
            //var _dangerDriveService = new DanDriveService();
            //var result = await _dangerDriveService.GetDangerDriveList();
            DangerDriveList = new NotifyTaskCompletion<List<DangerDriveViewModel>>(GetDangerDriveList());
        }

        private async Task<List<DangerDriveViewModel>> GetDangerDriveList()
        {
            var _dangerDriveService = new DanDriveService();
            var result = await _dangerDriveService.GetDangerDriveList();
            return result.Select(n => new DangerDriveViewModel(n)).ToList();
            //return result;
        }
        public NotifyTaskCompletion<List<DangerDriveViewModel>> DangerDriveList { get; private set; }
    }
}
