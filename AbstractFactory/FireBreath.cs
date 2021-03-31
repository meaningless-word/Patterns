using System;

namespace AbstractFactory
{
	/// <summary>
	/// Оружие драконов - огненное дыхание
	/// </summary>
	class FireBreath : IWeapon
	{
		public void Attack()
		{
			Console.WriteLine("Дышим огнем");
		}
	}
}
