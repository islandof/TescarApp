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
	public class ZhalanAlarmService
	{
		public async Task<List<ZhalanAlarm>> GetZhalanAlarmList (string keyValues)
		{
			var client = new HttpClient { BaseAddress = new Uri ("http://cloud.tescar.cn/vehicle/") };
		
			var response = await client.GetAsync (string.IsNullOrEmpty (keyValues) ? "gettboxxczhalanalarmdata?isspec=1" : "gettboxxczhalanalarmdata?isspec=1&chepaino=" + keyValues);
			var itemListJson = response.Content.ReadAsStringAsync ().Result;
			var fRows = JsonConvert.DeserializeObject<FormatRows> (itemListJson);
			var result = JsonConvert.DeserializeObject<List<ZhalanAlarm>> (fRows.rows.ToString ());
			return result;
		}
        
	}
}
