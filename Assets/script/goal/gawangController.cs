using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gawangController : MonoBehaviour
{
    public bool player1;
    public bool player2;
    public bool player3;
    public bool player4;
    public goalmanager Manager;

    private void OnCollisionEnter(Collision goal)
    {
        if (goal.collider.CompareTag("ball"))
        {
            if(player1)
            {
                Manager.AddScorePlayer1(1);
            }
            if(player2)
            {
                Manager.AddScorePlayer2(1);
            }
            if (player3)
            {
                Manager.AddScorePlayer3(1);
            }
           if(player4)
            {
                Manager.AddScorePlayer4(1);
            }
        }
    }
}
