using Godot;
using System;
using static GameConstants;

public partial class PlayerIdleState : PlayerState
{
    public override void _PhysicsProcess(double delta)
    {
        if (characterNode.direction != Vector2.Zero)
        {
            characterNode.stateMachineNode.SwitchState<PlayerMoveState>();
        }

    }

    public override void _Input(InputEvent @event)
    {
        if (Input.IsActionJustPressed(INPUT_DASH))
        {
            characterNode.stateMachineNode.SwitchState<PlayerDashState>();
        }
    }

    protected override void EnterState()
    {
        base.EnterState();
        characterNode.animPlayerNode.Play(ANIM_IDLE);
    }
}
