﻿using System;
using System.Collections.Generic;

namespace Observer
{
	/// <summary>
	/// Биржа
	/// </summary>
	class Stock : IObservable
	{
		/// <summary>
		/// Информация о торгах
		/// </summary>
		StockData _sData;
		List<IObserver> observers;
		public Stock()
		{
			observers = new List<IObserver>();
			_sData = new StockData();
		}

		public void RegisterObserver(IObserver o)
		{
			observers.Add(o);
		}

		public void RemoveObserver(IObserver o)
		{
			observers.Remove(o);
		}

		public void NotifyObservers()
		{
			foreach (IObserver o in observers)
			{
				o.Update(_sData);
			}
		}

		/// <summary>
		/// симуляция случайного поведения сессии торгов на рынке валют
		/// </summary>
		public void Market()
		{
			Random rnd = new Random();
			_sData.USD = rnd.Next(70, 90);
			_sData.Euro = rnd.Next(80, 100);
			NotifyObservers();
		}
	}
}
