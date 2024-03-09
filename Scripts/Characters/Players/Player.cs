using Godot;
using System;

public partial class Player : CharacterBody3D
{
    public override void _PhysicsProcess(double delta)
    {
        
    }

    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("move_forward")) {
            GD.Print("move forward");
        }
        GD.Print("Player Input");
    }


}
