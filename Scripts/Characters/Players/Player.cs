using Godot;
using System;
using static GameConstants;

public partial class Player : CharacterBody3D
{
    [ExportGroup("Required Nodes")]
    [Export] public AnimationPlayer animPlayerNode;
    [Export] public Sprite3D spriteNode;
    [Export] public StateMachine stateMachineNode;

    public Vector2 direction = new();
    public override void _PhysicsProcess(double delta)
    {
        Velocity = new(direction.X, 0, direction.Y);
        Velocity *= 5;

        MoveAndSlide();

        Flip();
    }

    public override void _Input(InputEvent @event)
    {
        direction = Input.GetVector(
            INPUT_MOVE_LEFT, INPUT_MOVE_RIGHT, INPUT_MOVE_FORWARD, INPUT_MOVE_BACKWARD
        );
    }

    private void Flip()
    {
        bool isNotMovingHorizontally = Velocity.X == 0;

        if (isNotMovingHorizontally) return;

        bool isMovingLeft = Velocity.X < 0;
        spriteNode.FlipH = isMovingLeft;
    }

}
