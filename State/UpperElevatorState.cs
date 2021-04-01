using System;

namespace State
{
	/// <summary>
	/// Реализация надземного состояния (лифт на верхних этажах)
	/// </summary>
	class UpperElevatorState : IElevatorState
	{
		public void Down(Elevator elevator)
		{
			Console.WriteLine("Опускаемся на первый этаж");
			elevator.ElevatorState = new GroundElevatorState();
		}

		public void Up(Elevator elevator)
		{
			Console.WriteLine("И так высоко, куда выше то?");
		}
	}
}
