using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Controller : MonoBehaviour
{
    // player 2 movement 
    private Rigidbody rb;
    public float speed = 10;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            rb.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.J))
        {
            rb.AddForce(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            rb.AddForce(Vector3.back * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
        }
    }
}