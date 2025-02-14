using UnityEngine;

public class idleState : State
{
    public override void OnEnter(HandlerState _state)
    {
        
    }
    public override void OnUpdate(HandlerState _state)
    {
        if(_state._input.dir != Vector2.zero)
            _state.changeState(_state._locomotion);
    }
    public override void OnExit(HandlerState _state)
    {
        
    }
}
