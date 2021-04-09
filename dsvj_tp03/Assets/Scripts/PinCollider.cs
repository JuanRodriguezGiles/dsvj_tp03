using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PinCollider : MonoBehaviour
{
    public GameObject gameStatus;
    private GameStatus gameStatusScript;
    public GameObject ball;
    private Ball ballScript;
    void Start()
    {
        gameStatusScript = gameStatus.GetComponent<GameStatus>();
        ballScript = ball.GetComponent<Ball>();
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Pin")
            gameStatusScript.pinsLeft--;
        if (col.gameObject.tag == "Ball")
            ballScript.resetBall();
    }
}