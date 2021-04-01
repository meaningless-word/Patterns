using System;

namespace State
{
	/// <summary>
	/// Реализация подземного состояния (лифт в подвале)
	/// </summary>
	class LowerElevatorState : IElevatorState
	{
		public void Down(Elevator elevator)
		{
			Console.WriteLine("Ниже некуда");
		}

		public void Up(Elevator elevator)
		{
			Console.WriteLine("Поднимаемся на первый этаж");
			elevator.ElevatorState = new GroundElevatorState();
		}
	}
}
