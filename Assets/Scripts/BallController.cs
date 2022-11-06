using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private Rigidbody _rigidbody;
    [SerializeField] private float power = 10;
    [SerializeField] private GameManager gameManager;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.IsPaused)
        {
            return;
        }
        
        // Add force with accelerometer
        Vector3 force = new Vector3(Input.acceleration.x, 0, Input.acceleration.y);
        _rigidbody.AddForce(force * power);
    
        // Add force with keyboard
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(Vector3.forward * power);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(Vector3.back * power);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector3.left * power);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector3.right * power);
        }
        
        
        
    }
}
