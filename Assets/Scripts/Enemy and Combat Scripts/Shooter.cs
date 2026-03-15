using UnityEngine;
using UnityEngine.InputSystem;

public class Shooter : MonoBehaviour
{
    [Header("Shooter Settings")]
    [SerializeField] private InputAction shootInput; // setting the input that allows player to shoot
    [SerializeField] private Transform shootPoint; // where we are shooting the arrow from
    [SerializeField] private GameObject shootObject; // what prefab we are using as a projectile
    [SerializeField] private float shootForce; // how much force to use when shooting

    private GameObject _arrow;

    private void OnEnable()
    {
        shootInput.Enable();
        shootInput.performed += Shoot;
    }

    private void OnDisable()
    {
        shootInput.performed -= Shoot; 
    }
    
    private void Shoot(InputAction.CallbackContext context)
        {
            //creating a new arrow
           _arrow = Instantiate(shootObject, shootPoint.position, shootPoint.rotation);
           
           //applying force
           _arrow.GetComponent<Rigidbody>().AddForce(shootForce * shootPoint.forward);
           
           Destroy(_arrow, 5f); //destroy the arrow after 5 seconds
        }

    
}
