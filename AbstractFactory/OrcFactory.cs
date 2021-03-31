using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	/// <summary>
	/// У нас есть фабрика по производству орков!
	/// Саурон нервно курит в сторонке.
	/// </summary>
	class OrcFactory : IMonsterFactory
	{
		public IMovement CreateMovement()
		{
			return new RunMovement();
		}
		public IWeapon CreateWeapon()
		{
			return new Axe();
		}
	}
}
