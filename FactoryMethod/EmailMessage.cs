using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
	class EmailMessage: Message
	{
		public EmailMessage()
		{
			Console.WriteLine("e-mail отправлен");
		}
	}
}
