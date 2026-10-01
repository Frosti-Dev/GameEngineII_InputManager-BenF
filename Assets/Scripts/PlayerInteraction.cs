using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    private InputManager input;
    private IInteractable targetInteractable;

    [SerializeField] private GameObject debugCurrentInteractable;


    private void Start()
    {
        input = FindAnyObjectByType<InputManager>();
    }

    private void Update()
    {
        CheckInteract();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = foundInteractable;
            debugCurrentInteractable = other.gameObject;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = null;
            debugCurrentInteractable = null;
        }
    }

    public void CheckInteract()
    {
        if (input.isInteracting & targetInteractable != null)
        {
             Debug.Log("Player Interaction Log");
            targetInteractable.Interact();
        }
    }
}
