using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeByInput : MonoBehaviour
{

    private Rigidbody rb;
    public float moveFactor = 10.0f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.I))
        {
            rb.AddForce(Vector3.forward * moveFactor);
        }
        if (Input.GetKey(KeyCode.J))
        {
            rb.AddForce(Vector3.left * moveFactor);
        }
        if (Input.GetKey(KeyCode.K))
        {
            rb.AddForce(Vector3.down * moveFactor);
        }
        if (Input.GetKey(KeyCode.L))
        {
            rb.AddForce(Vector3.right * moveFactor);
        }
    }
}
