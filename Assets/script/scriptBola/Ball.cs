using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 initialImpluse;
    public Rigidbody rb;

    public Vector3 resetPosition;
    void Start()
    {
        rb.AddForce(initialImpluse, ForceMode.Impulse);
    }
    private void update()
    {
        
    }

    private void OnCollisionEnter(Collision kena)
    {
        if (kena.collider.CompareTag("gawang"))
        {
            //Destroy(gameObject);
            transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
