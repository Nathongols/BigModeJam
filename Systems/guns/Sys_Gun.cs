using Godot;
using System;

public partial class Sys_Gun : Node
{
	private static Vector2 mousepos;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public static void RotateGun(){
		Entities._gun.Rotation = Entities._player.position.AngleToPoint(mousepos);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public static void tick(Node node){
		RotateGun();
		mousepos = node.GetViewport().GetMousePosition();

		if (Input.IsActionPressed("leftclick")){
			//instantiate bullet buh
		}
	}
		
}
