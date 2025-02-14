using UnityEngine;

public abstract class State
{
    /// <summary>
    /// classe State é a base dos estados
    /// por exemplo se eu for criar um estado de pulo eu vou herdar State e usar os metodos abaixo
    /// 
    /// HANDLE STATE é um controlador
    /// 
    /// </summary>

    HandlerState st;
    public virtual void OnEnter(HandlerState _state) { st = _state; }
    public virtual void OnUpdate(HandlerState _state) { st = _state; }
    public virtual void OnExit(HandlerState _state) { st = _state; }
}
