using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player4 : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            rb.velocity = new Vector3(0, 0, -speed);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
