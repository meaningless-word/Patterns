using System;

namespace Adapter
{
	class PaperPrinter : IPrinter
	{
		/// <summary>
		/// Класс для работы с принтером
		/// </summary>
		public void Print()
		{
			Console.WriteLine("Печатаем на бумаге");
		}
	}
}
