using Godot;
using System;
public partial class Entities : Node
{
	//ENTITIES
	private PackedScene PlayerScene = ResourceLoader.Load<PackedScene>("res://Entities/Player/player.tscn");
	public static Player _player {get; private set;} // Active player

	private PackedScene GunScene = ResourceLoader.Load<PackedScene>("res://Entities/Gun/gun.tscn");
	public static Gun1 _gun {get; private set;} // Active player

	public override void _Ready()
	{
		_player = PlayerScene.Instantiate<Player>(); //Init Pos, Player
        AddChild(_player);
		_gun = GunScene.Instantiate<Gun1>();
		AddChild(_gun);

	}

}
