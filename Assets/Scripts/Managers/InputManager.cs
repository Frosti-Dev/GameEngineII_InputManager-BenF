using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager manager;

    public Vector2 playerMoveInput;
    public bool isSprinting;
    public bool isInteracting;
    
    
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
        Debug.Log("Input Manager Log");
        isInteracting = value.isPressed;
    }

    void OnSprint(InputValue value)
    {
        isSprinting = value.isPressed;
    }
}
