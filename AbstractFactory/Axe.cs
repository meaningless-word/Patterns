﻿using System;

namespace AbstractFactory
{
	/// <summary>
	/// Топор - оружие орков
	/// </summary>
	class Axe : IWeapon
	{
		public void Attack()
		{
			Console.WriteLine("Бьем топором");
		}
	}
}
