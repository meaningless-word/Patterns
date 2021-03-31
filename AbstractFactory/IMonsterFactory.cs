namespace AbstractFactory
{
	/// <summary>
	///  Интерфейс абстрактной фабрики
	/// </summary>
	interface IMonsterFactory
	{
		IMovement CreateMovement();
		IWeapon CreateWeapon();
	}
}
