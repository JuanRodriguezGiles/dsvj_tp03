using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class UI : MonoBehaviour
{
    public GameObject ball;
    private Ball ballScript;
    public GameObject pinCollider;
    public TMP_Text force;
    void Start()
    {
        ballScript = ball.GetComponent<Ball>();
    }
    void Update()
    {
        force.text = Mathf.Round(ballScript.force).ToString();
    }
}
