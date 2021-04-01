using System;

namespace Observer
{
	/// <summary>
	/// Общий интерфейс наблюдателя
	/// </summary>
	interface IObserver
	{
		void Update(Object o);
	}
}
