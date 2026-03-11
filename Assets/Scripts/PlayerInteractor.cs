using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractor : MonoBehaviour
{
    //Input
    [SerializeField] private InputAction interactionInput;

    private IInteractable _interactable;
    private IInteractable _tempInteractable;

    void OnEnable()
    {
        interactionInput.Enable();
        interactionInput.performed += Interact;
    }

    void OnDisable()
    {
       interactionInput.performed -= Interact;
    }

    private void OnTriggerEnter(Collider other)
    {
        _tempInteractable = other.GetComponent<IInteractable>();

        if (_tempInteractable == null) return;
        
        _interactable = _tempInteractable;
        _interactable?.OnHoverIn();
    }

    private void OnTriggerExit(Collider other)
    {
        _interactable?.OnHoverOut();
        _interactable = null; //let go of interactable
    }

    private void Interact(InputAction.CallbackContext context)
    {
        _interactable?.OnInteract();
        Debug.Log("Interact");
    }
}
