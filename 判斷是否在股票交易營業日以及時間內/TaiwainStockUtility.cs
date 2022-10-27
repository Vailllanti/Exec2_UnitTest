using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace 判斷是否在股票交易營業日以及時間內
{
	public class TaiwainStockUtility
	{
		/// <summary>
		/// 判斷是否在台灣股票交易營業日以及時間內
		/// </summary>
		/// <param name="dateTime">輸入需判斷的時間，e.g.2022/10/22 09:07</param>
		/// <returns>如果是傳回ture，反之傳回false</returns>
		public bool IsTradingTime(DateTime dateTime)
		{
			//日期必需在星期一~星期五
			DayOfWeek weekday = dateTime.DayOfWeek;

			if (weekday == DayOfWeek.Sunday || weekday == DayOfWeek.Saturday)
			{
				return false; 
			}

			//時間必需介於9:00 ~ 13:30
			DateTime tradStart = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddHours(9);
			DateTime tradEnd = tradStart.AddHours(4.5);

			if (dateTime < tradStart || dateTime > tradEnd)
			{
				return false;
			}

			return true;
		}
	}
}
