using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    public Rigidbody rig;
    public Vector3 arah;
    public Vector3 resetPosition;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = arah;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }
}
