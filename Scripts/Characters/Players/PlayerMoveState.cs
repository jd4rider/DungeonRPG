using Godot;
using System;
using static GameConstants;

public partial class PlayerMoveState : Node
{

    public override void _Ready()
    {
        Player characterNode = GetOwner<Player>();
        characterNode.animPlayerNode.Play(ANIM_MOVE);
    }
}
