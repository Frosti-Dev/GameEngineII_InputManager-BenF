using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputManager input;

    private Rigidbody2D rb;
    private Vector2 playerInput;

    private float moveSpeed;
    public float normalSpeed = 5f;
    public float sprintSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        input = FindAnyObjectByType<InputManager>();
    }

    void Update()
    {
        CheckMove();
    }

    void CheckMove()
    {
        playerInput = input.playerMoveInput;

        CheckSprint();
        rb.MovePosition(rb.position + playerInput * moveSpeed * Time.fixedDeltaTime);
    }
    void CheckSprint()
    {
        moveSpeed = input.isSprinting ? sprintSpeed : normalSpeed;
    }

    void CheckInteractable()
    {
        
    }
}
