namespace ChainOfResponsibility
{
	/// <summary>
	/// Получатель уведомлений
	/// </summary>
	class Receiver
	{
		public bool EmailNotification { get; set; }
		public bool SmsNotification { get; set; }
		public bool VoiceNotification { get; set; }
		public Receiver(bool emailNotification, bool smsNotification, bool voiceNotification)
		{
			EmailNotification = emailNotification;
			SmsNotification = smsNotification;
			VoiceNotification = voiceNotification;
		}
	}
}
