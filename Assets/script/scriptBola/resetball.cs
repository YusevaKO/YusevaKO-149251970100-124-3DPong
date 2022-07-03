using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetball : MonoBehaviour
{
    public Vector3 resetPosition;
    private void OnCollisionEnter(Collision kena)
    {
        if (kena.collider.CompareTag("gawang"))
        {
            //Destroy(gameObject);
            transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z );
        }
    }
}
