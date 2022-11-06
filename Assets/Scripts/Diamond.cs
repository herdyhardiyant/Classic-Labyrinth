using UnityEngine;

public class Diamond : MonoBehaviour
{
    
    [SerializeField] private GameManager gameManager;
    [SerializeField] private float rotationSpeed = .5f;
    
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.CollectDiamond();
            Destroy(gameObject);
        }
    }
}
