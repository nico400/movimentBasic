using UnityEngine;

public class inputHandlers : MonoBehaviour
{
    InputSystem_Actions inputs;

    public Vector2 dir {get; private set;}

    void Awake()
    {
        inputs = new InputSystem_Actions();
    }
    private void OnEnable()
    {
        inputs.Enable();
    }
    private void OnDisable()
    {
        inputs.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        dir = inputs.Player.Move.ReadValue<Vector2>();
    }
}
