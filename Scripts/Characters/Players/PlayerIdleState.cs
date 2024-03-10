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
}
