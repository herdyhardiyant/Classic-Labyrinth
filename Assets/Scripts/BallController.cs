using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private Rigidbody _rigidbody;
    [SerializeField] private float power = 10;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Add force with accelerometer
        Vector3 force = new Vector3(Input.acceleration.x, 0, Input.acceleration.y);
        _rigidbody.AddForce(force * power);

    }
}
