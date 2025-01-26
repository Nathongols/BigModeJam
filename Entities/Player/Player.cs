using Godot;
using System;


public partial class Player : Node2D
{
    internal int _health; // Backing field

    [Export]
    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }
}
