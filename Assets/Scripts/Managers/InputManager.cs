using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager manager;

    public Vector2 playerMoveInput;
    public bool isSprinting;
    
    
    void Awake()
    {
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }

        else if (manager != null)
        {
            Destroy(gameObject);
        }
    }

    void OnMove(InputValue value)
    {
        playerMoveInput = value.Get<Vector2>();
    }

    void OnInteract(InputValue value)
    {
        if (value.isPressed)
        {

        }
    }

    void OnSprint(InputValue value)
    {
        isSprinting = value.isPressed;
    }
}
