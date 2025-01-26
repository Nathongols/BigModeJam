using Godot;
using System;
public partial class Entities : Node
{
	//ENTITIES
	private PackedScene PlayerScene = ResourceLoader.Load<PackedScene>("res://Entities/Player/player.tscn");
	public static Player _player {get; private set;} // Active player

	public override void _Ready()
	{
		_player = PlayerScene.Instantiate<Player>(); //Init Pos, Player
        AddChild(_player);

	}

}
