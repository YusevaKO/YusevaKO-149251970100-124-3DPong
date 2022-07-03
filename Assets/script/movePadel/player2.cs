using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed, 0, 0);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
