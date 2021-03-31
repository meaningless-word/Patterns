using System;

namespace AbstractFactory
{
	/// <summary>
	/// Большинству наземных монстров доступен бег
	/// </summary>
	class RunMovement : IMovement
	{
		public void Start()
		{
			Console.WriteLine("Бежим");
		}
	}
}
