using System;

namespace FactoryMethod
{
	class SmsMessage: Message
	{
		public SmsMessage()
		{
			Console.WriteLine("SMS отправлено");
		}
	}
}
