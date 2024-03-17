using Godot;
using System;
using static GameConstants;

public partial class StateMachine : Node
{
    [Export] private Node currentState;
    [Export] private Node[] states;

    public override void _Ready()
    {
        currentState.Notification(NOTIFICATION_ENTER_STATE);
    }

    public void SwitchState<T>()
    {
        Node newState = null;
        foreach (Node state in states)
        {
            if (state is T)
            {
                newState = state;
            }
        }
        if (newState == null) return;
        currentState.Notification(NOTIFICATION_EXIT_STATE);
        currentState = newState;
        currentState.Notification(NOTIFICATION_ENTER_STATE);
    }
}
