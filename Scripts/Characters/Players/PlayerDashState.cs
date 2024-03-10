using Godot;
using System;
using static GameConstants;

public partial class PlayerDashState : Node
{
    private Player characterNode;

    public override void _Ready()
    {
        characterNode = GetOwner<Player>();
        //SetPhysicsProcess(false);
    }

    public override void _Notification(int what)
    {
        base._Notification(what);

        if (what == 5001)
        {
            characterNode.animPlayerNode.Play(ANIM_DASH);
            //SetPhysicsProcess(true);
        }
        //else if (what == 5002) SetPhysicsProcess(false);
    }
}

