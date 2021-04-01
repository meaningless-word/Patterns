using System;

namespace Adapter
{
	/// <summary>
	/// Класс для работы с устройством, печатающим на холсте 
	/// </summary>
	class CanvasPainter : IPainter
	{
		public void Paint()
		{
			Console.WriteLine("Рисуем на холсте");
		}
	}
}
