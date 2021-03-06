﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountScore : MonoBehaviour
{
    public Text Scoreboard;
    public GameObject ball;

    private int Bat_1_Score = 0;
    private int Bat_2_Score = 0;


    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x >= 17f)
        {
            Bat_1_Score ++;
        }

        if (ball.transform.position.x <= -17f)
        {
            Bat_2_Score ++;
        }

        if (Bat_1_Score >= 2)
        {
            //SceneManager.LoadScene (2);
            NvpEventController.InvokeEvent(NvpGameEvents.OnPlayer1Wins, this, null);
        }

        if (Bat_2_Score >= 2)
        {
            //SceneManager.LoadScene(3);
            NvpEventController.InvokeEvent(NvpGameEvents.OnPlayer2Wins, this, null);
        }

        Scoreboard.text = Bat_1_Score.ToString() + " - " + Bat_2_Score.ToString() ;

        print(Bat_1_Score + " , " + Bat_2_Score);
    }
}
