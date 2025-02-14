using UnityEngine;

public class locomotionState : State
{
    public override void OnEnter(HandlerState _state)
    {
        
    }
    public override void OnUpdate(HandlerState _state)
    {
       if(_state._input.dir == Vector2.zero)
            _state.changeState(_state._idle);

        locomotionPlayer(_state._input.dir, _state._comp);
        rotationPlayer(_state._input.dir, _state._comp);
    }
    public override void OnExit(HandlerState _state)
    {
        
    }
    void locomotionPlayer(Vector2 DirToWalk, Components comp)
    {
        Vector3 dirMove = comp.cam.forward * DirToWalk.y + comp.cam.right * DirToWalk.x;
        dirMove = dirMove.normalized * comp.speed;
        dirMove.y = 0;

        comp.rb.linearVelocity = dirMove;
    }
    void rotationPlayer(Vector2 DirToWalk, Components comp)
    {
        Vector3 dirMove = comp.cam.forward * DirToWalk.y + comp.cam.right * DirToWalk.x;
        dirMove.Normalize();
        dirMove.y = 0;

        Quaternion rot = Quaternion.LookRotation(dirMove, comp.transform.up);
        comp.rb.rotation = Quaternion.Slerp(comp.rb.rotation, rot, 7.5f * Time.deltaTime);
    }
}
