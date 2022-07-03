using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalmanager : MonoBehaviour
{
    public int ScorePlayer1;
    public int ScorePlayer2;
    public int ScorePlayer3;
    public int ScorePlayer4;

    public int maxScore;
    int PlayerKalah;
    public int TotalPlayerKalah;
    public GameObject Finish;

    public GameObject tembok1;
    public GameObject tembok2;
    public GameObject tembok3;
    public GameObject tembok4;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public void AddScorePlayer1(int increment)
    {
        ScorePlayer1 += increment;
        if(ScorePlayer1>= maxScore)
        {
            player1.SetActive(false);
            tembok1.SetActive(true);
            PlayerKalah += 15;
        }
    }
    public void AddScorePlayer2(int increment)
    {
        ScorePlayer2 += increment;
        if (ScorePlayer2 >= maxScore)
        {
            player2.SetActive(false);
            tembok2.SetActive(true);
            PlayerKalah +=15;
        }
    }
    public void AddScorePlayer3(int increment)
    {
        ScorePlayer3 += increment;
        if (ScorePlayer3 >= maxScore)
        {
            player3.SetActive(false);
            tembok3.SetActive(true);
            PlayerKalah +=15;
        }
    }
    public void AddScorePlayer4(int increment)
    {
        ScorePlayer4 += increment;
        if (ScorePlayer4 >= maxScore)
        {
            player4.SetActive(false);
            tembok4.SetActive(true);
            PlayerKalah += 15;
        }
    }
    void Start()
    {
        Finish.SetActive(false);
    }
    void Update()
    {
        if (PlayerKalah >= TotalPlayerKalah)
        {
            Debug.Log(TotalPlayerKalah);
            Time.timeScale = 0;
            Finish.SetActive(true);
        }
        if (PlayerKalah != 15)
        {

        }
    }
}
