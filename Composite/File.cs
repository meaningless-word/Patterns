using System;

namespace Composite
{
	/// <summary>
	/// Представляет компонент самого низкого уровня
	/// Который не может содержать подкомпонентов
	/// </summary>
	class File : Component
	{
		public File(string name) : base(name)
		{ 
		}

		// Метод для добавления подкомпонентов не поддерживается
		public override void Add(Component c)
		{
			throw new NotImplementedException();
		}

		// Метод для удаления подкомпонентов не поддерживается
		public override void Remove(Component c)
		{
			throw new NotImplementedException();
		}

		// Метод отображения
		public override void Display()
		{
			Console.WriteLine(Name);
		}
	}
}
