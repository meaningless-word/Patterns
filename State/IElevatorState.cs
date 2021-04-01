namespace State
{
	interface IElevatorState
	{
		void Up(Elevator elevator);
		void Down(Elevator elevator);
	}
}
