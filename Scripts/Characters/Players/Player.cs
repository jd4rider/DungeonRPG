using Godot;
using System;
using static GameConstants;

public partial class Player : CharacterBody3D
{
    [ExportGroup("Required Nodes")]
    [Export] private AnimationPlayer animPlayerNode;
    [Export] private Sprite3D spriteNode;

    public override void _Ready() 
    {
        animPlayerNode.Play(ANIM_IDLE);
    }
    private Vector2 direction = new();
    public override void _PhysicsProcess(double delta)
    {
        Velocity = new(direction.X, 0, direction.Y);
        Velocity *= 5;

        MoveAndSlide();
    }

    public override void _Input(InputEvent @event)
    {
        direction = Input.GetVector(
            INPUT_MOVE_LEFT, INPUT_MOVE_RIGHT, INPUT_MOVE_FORWARD, INPUT_MOVE_BACKWARD
        );

        if (direction == Vector2.Zero) {
            animPlayerNode.Play(ANIM_IDLE);
        } else animPlayerNode.Play(ANIM_MOVE);
    }


}
