using Godot;
using static GameConstants;

public abstract partial class PlayerState : Node
{
    protected Player characterNode;

    public override void _Ready()
    {
        characterNode = GetOwner<Player>();
        SetPhysicsProcess(false);
        SetProcessInput(false);
    }

    public override void _Notification(int what)
    {
        base._Notification(what);

        if (what == NOTIFICATION_ENTER_STATE)
        {
            EnterState();
            SetPhysicsProcess(true);
            SetProcessInput(true);
        }
        else if (what == NOTIFICATION_EXIT_STATE)
        {
            SetPhysicsProcess(false);
            SetProcessInput(false);
        }
    }

    protected virtual void EnterState() { }
}
