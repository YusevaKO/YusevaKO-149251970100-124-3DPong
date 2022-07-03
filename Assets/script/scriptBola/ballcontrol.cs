using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    public Vector3 resetPosition;
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }
}
