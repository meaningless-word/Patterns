using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
	/// <summary>
	/// Класс для отрисовки изображений
	/// </summary>
	class ImageDrawer
	{
		// Метод, запускающий печать с помощью внешнего устройства
		public void DrawWith(IPrinter printer)
		{
			printer.Print();
		}
	}
}
