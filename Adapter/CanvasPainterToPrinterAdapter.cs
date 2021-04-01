using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
	/// <summary>
	/// Адаптер от CanvasPainter к IPrinter
	/// </summary>
	class CanvasPainterToPrinterAdapter : IPrinter
	{
		private CanvasPainter _canvasPainter;

		public CanvasPainterToPrinterAdapter(CanvasPainter canvasPainter)
		{
			_canvasPainter = canvasPainter;
		}
		public void Print()
		{
			_canvasPainter.Paint();
		}
	}
}
