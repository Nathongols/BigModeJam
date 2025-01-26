using Godot;
using System;

public partial class Gun1 : Node2D
{
	internal int _basedmg; // Backing field
    [Export]
    public int BaseDmg
    {
        get { return _basedmg; }
        set { _basedmg = value; }
    }

	internal int _bvelocity; // Backing field

    [Export]
    public int BVelocity
    {
        get { return _bvelocity; }
        set { _bvelocity = value; }
    }
}
