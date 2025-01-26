using Godot;
using System;


public partial class Player : Node2D
{
    internal Vector2 position = new Vector2(0,0);
    internal int _health; // Backing field

    [Export]
    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }
    
}
