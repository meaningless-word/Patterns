namespace AbstractFactory
{
	/// <summary>
	/// У нас есть фабрика по производству драконов!
	/// Дейенерис нервно курит в сторонке
	/// </summary>
	class DragonFactory : IMonsterFactory
	{
		public IMovement CreateMovement()
		{
			return new FlyMovement();
		}
		public IWeapon CreateWeapon()
		{
			return new FireBreath();
		}
	}
}
