using Godot;
using System;
using static GameConstants;

public partial class PlayerMoveState : PlayerState
{

    [Export(PropertyHint.Range, "0,20,0.1")] private float MoveSpeed = 5;

    public override void _PhysicsProcess(double delta)
    {
        if (characterNode.direction == Vector2.Zero)
        {
            characterNode.StateMachineNode.SwitchState<PlayerIdleState>();
            return;
        }
        characterNode.Velocity = new(characterNode.direction.X, 0, characterNode.direction.Y);
        characterNode.Velocity *= MoveSpeed;

        characterNode.MoveAndSlide();

        characterNode.Flip();
    }

    protected override void EnterState()
    {
        base.EnterState();

        characterNode.AnimPlayerNode.Play(ANIM_MOVE);
    }

    public override void _Input(InputEvent @event)
    {
        if (Input.IsActionJustPressed(INPUT_DASH))
        {
            characterNode.StateMachineNode.SwitchState<PlayerDashState>();
        }
    }
}
