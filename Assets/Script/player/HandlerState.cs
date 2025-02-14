using UnityEngine;

public class HandlerState : MonoBehaviour
{
    /// <summary>
    /// Controlador dos estados, aqui vc vai criar os obj dos estados novos,
    /// controlar o estado atual e mudar para outro estado (parado para correndo por exemplo)
    /// 
    /// para fazer um estado trocar para outro usa se o metodo CHANGE STATE
    /// 
    /// </summary>
    State currentState;
    public inputHandlers _input;
    public Components _comp;
    public idleState _idle = new idleState();
    public locomotionState _locomotion = new locomotionState();

    void Start()
    {
        //começa no estado parado
        changeState(_idle);
    }
    void Update()
    {
        if(currentState != null)
            currentState.OnUpdate(this);
    }
    public void changeState(State newState)
    {
        if (currentState != null)
        {
            currentState.OnExit(this);
        }
        currentState = newState;
        currentState.OnEnter(this);
    }
}
