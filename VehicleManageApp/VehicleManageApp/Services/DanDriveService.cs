﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using VehicleManageApp.ViewModels;
using VehicleManageApp.Model;

namespace VehicleManageApp.Services
{
	public class DanDriveService : IDanDriveService
	{
		public async Task<List<DangerDrive>> GetDangerDriveList (string keyValues)
		{
			var client = new HttpClient { BaseAddress = new Uri ("http://cloud.tescar.cn/vehicle/") };
		
			var response = await client.GetAsync (string.IsNullOrEmpty (keyValues) ? "GetTboxalarmintimeData?isspec=1" : "GetTboxalarmintimeData?isspec=1&chepaino=" + keyValues);
			var itemListJson = response.Content.ReadAsStringAsync ().Result;
			var fRows = JsonConvert.DeserializeObject<FormatRows> (itemListJson);
			var result = JsonConvert.DeserializeObject<List<DangerDrive>> (fRows.rows.ToString ());
			return result;
		}
        
	}
}
