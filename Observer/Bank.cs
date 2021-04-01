﻿using System;

namespace Observer
{
	/// <summary>
	/// Реализация банка в качестве наблюдателя
	/// </summary>
	class Bank : IObserver
	{
		IObservable stock;
		public Bank(IObservable obs)
		{
			stock = obs;
			stock.RegisterObserver(this);
		}

		public void Update(object o)
		{
			StockData sData = (StockData)o;

			if (sData.Euro > 85)
				Console.WriteLine($"Банк продает евро по курсу {sData.Euro}");
			else
				Console.WriteLine($"Банк покупает евро по курсу {sData.Euro}");
		}
	}
}
