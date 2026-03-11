using UnityEngine;

public class ChestInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator anim;

    private int IsOpenHash;
    
    void Start()
    {
        if (!anim) return;
        
        IsOpenHash = Animator.StringToHash("IsOpen");
    }
    
    public void OnHoverIn()
    {
       anim?.SetBool(IsOpenHash, true);
       Debug.Log("HoverIn");
    }
    //TODO: add UI

    public void OnHoverOut()
    {
        anim?.SetBool(IsOpenHash, false);
        Debug.Log("HoverOut");
    }
    
    //TODO: hide UI

    public void OnInteract()
    {
        
        Debug.Log("Interact");
        
    }
}
