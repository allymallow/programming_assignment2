using DG.Tweening;
using UnityEditor.UI;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

   [Header("Enemy Movement")]
    [SerializeField] private Transform enemyPrefab;
    [SerializeField] private float enemyHealth;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float jumpHeight;

    [SerializeField] private LayerMask PlayerLayer;


    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Player"))
        {
            
        }
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
