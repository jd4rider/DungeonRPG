using Godot;
using System;
using static GameConstants;

public partial class Player : CharacterBody3D
{
    [ExportGroup("Required Nodes")]
    [Export] public AnimationPlayer AnimPlayerNode { get; private set; }
    [Export] public Sprite3D SpriteNode { get; private set; }
    [Export] public StateMachine StateMachineNode { get; private set; }

    public Vector2 direction = new();

    public override void _Input(InputEvent @event)
    {
        direction = Input.GetVector(
            INPUT_MOVE_LEFT, INPUT_MOVE_RIGHT, INPUT_MOVE_FORWARD, INPUT_MOVE_BACKWARD
        );
    }

    public void Flip()
    {
        bool isNotMovingHorizontally = Velocity.X == 0;

        if (isNotMovingHorizontally) return;

        bool isMovingLeft = Velocity.X < 0;
        SpriteNode.FlipH = isMovingLeft;
    }

}
