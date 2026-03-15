using UnityEngine;

public class MouseBehaviour : MonoBehaviour
{
    void Start()
    {
        ShowMouse(false); // hiding the mnouse pointer
    }

    public void ShowMouse(bool value)
    {
        //setting the cursor visibility via bool
        //as well as determining whether it is locked in centre of screen vs free to move when needed
        Cursor.visible = value;
        Cursor.lockState = value ? CursorLockMode.None : CursorLockMode.Locked;
    }
}
