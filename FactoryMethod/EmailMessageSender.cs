﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
	/// <summary>
	/// Класс для рассылки e-mail
	/// </summary>
	class EmailMessageSender : MessageSender
	{
		public EmailMessageSender(string @from) : base(@from)
		{ 
		}

		public override Message Send(string text)
		{
			return new EmailMessage();
		}
	}
}
