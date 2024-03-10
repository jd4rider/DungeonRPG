using Godot;
using System;
using static GameConstants;

public partial class PlayerIdleState : Node
{
    private Player characterNode;

    public override void _Ready()
    {
        characterNode = GetOwner<Player>();
        characterNode.animPlayerNode.Play(ANIM_IDLE);
    }

    public override void _PhysicsProcess(double delta)
    {
        if (characterNode.direction != Vector2.Zero)
        {
            characterNode.stateMachineNode.SwitchState<PlayerMoveState>();
        }
    }


    public override void _Notification(int what)
    {
        base._Notification(what);

        if (what == 5001)
        {
            characterNode.animPlayerNode.Play(ANIM_IDLE);
        }
    }
}
