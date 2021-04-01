﻿using System;

namespace AbstractFactory
{
	// Порождающие паттерны

	/*
	 * Применять стоит в следующих случаях: 
	 * Ваша система не должна зависеть от способа компоновки объектов.
	 * Объекты в вашей системе должны использоваться вместе и быть взаимосвязанными.
	 */

	class Program
	{
		/*
		 * У нас будет небольшая игра, где, конечно же, есть монстры. При этом разные монстры имеют разное оружие. 
		 * Также у нас будут как обычные, так и летающие монстры (а значит, надо предусмотреть им разные способы передвижения).
		 * Нашим монстрам нужны комплексные признаки. 
		 * Например, орк может бегать и владеет топором, но это скучно и не очень эффективно, поэтому будут ещё драконы, способные летать и дышать огнём.
		 * Таким образом получается, что для наших монстров тип оружия и модель передвижения будут взаимосвязанными, и использоваться будут в комплексе, 
		 * значит, есть довод в пользу абстрактной фабрики.
		 * Кроме того, используя её, мы сможем отделить (абстрагировать) создание монстров от самого класса монстра, и создать более гибкую архитектуру.
		 */

		// Начнём с создания моделей для движений: IMovement, FlyMovement, RunMovement

		// Создадим модели оружия: IWeapon, Axe, FireBreath

		// Перейдем к созданию абстрактной фабрики: IMonsterFactory

		// Создадим конкретные реализации фабрики: DragonFactory, OrcFactory

		// Создадим класс монстра, где будут использоваться фабрики: Monster

		// Теперь применим реализации на практике! 

		static void Main(string[] args)
		{
			// Создание дракона через фабрику
			var dragon = new Monster(new DragonFactory());
			dragon.Move();
			dragon.Hit();

			Console.WriteLine();
			// Создание орка через фабрику
			var orc = new Monster(new OrcFactory());
			orc.Move();
			orc.Hit();

			Console.WriteLine();
			Console.WriteLine("Всем конец...");
		}

		// Среди преимуществ здесь можно отметить то, что создание монстра абстрагировано от самого класса монстра.
		/*
		 * Но шаблон также имеет и свои недостатки. К примеру, если мы решим добавить монстрам новый объект конфигурации (например, тип брони),
		 * то придётся переделывать и классы фабрик, и класс монстра. То есть данный паттерн, как и все, имеет свои ограничения.
		 */
	}
}
