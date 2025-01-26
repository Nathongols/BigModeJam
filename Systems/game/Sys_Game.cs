using Godot;
using System;

public partial class Sys_Game : Node
{
	public override void _Ready()
	{
		Console.WriteLine(Entities._player.Health);
		Entities._player.Health = 500;
		Console.WriteLine(Entities._player.Health);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Sys_Ptest.tick(ref Entities._player._health);
		Console.WriteLine(Entities._player.Health);
	}
}
