using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goalControl : MonoBehaviour
{
    public Text skorPlayer1;
    public Text skorPlayer2;
    public Text skorPlayer3;
    public Text skorPlayer4;

    public goalmanager manager;
    private void Update()
    {
        skorPlayer1.text = manager.ScorePlayer1.ToString();
        skorPlayer2.text = manager.ScorePlayer2.ToString();
        skorPlayer3.text = manager.ScorePlayer3.ToString();
        skorPlayer4.text = manager.ScorePlayer4.ToString();
    }
}
