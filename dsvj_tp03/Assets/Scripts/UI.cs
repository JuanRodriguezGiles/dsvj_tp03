using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class UI : MonoBehaviour
{
    public GameObject ball;
    private Ball ballScript;
    public GameObject gameStatus;
    private GameStatus gameStatusScript;
    public TMP_Text force;
    public TMP_Text pinsLeft;
    public TMP_Text shotsLeft;
    void Start()
    {
        ballScript = ball.GetComponent<Ball>();
        gameStatusScript = gameStatus.GetComponent<GameStatus>();
    }
    void Update()
    {
        force.text = "Force: " + Mathf.Round(ballScript.force).ToString();
        shotsLeft.text = "Shots Left: " + gameStatusScript.shotsLeft.ToString();
        pinsLeft.text = "Pins Left: " + gameStatusScript.pinsLeft.ToString();
    }
}
