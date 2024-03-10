using Godot;
using System;
using static GameConstants;

public partial class PlayerIdleState : Node
{
    public override void _Ready()
    {
        Player characterNode = GetOwner<Player>();
        characterNode.animPlayerNode.Play(ANIM_IDLE);
    }

    public override void _Notification(int what)
    {
        base._Notification(what);

        if (what == 5001)
        {
            Player characterNode = GetOwner<Player>();
            characterNode.animPlayerNode.Play(ANIM_IDLE);
        }
    }
}
