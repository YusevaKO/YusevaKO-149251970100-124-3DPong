using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player3 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.O))
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            rb.velocity = new Vector3(0, 0, -speed);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
