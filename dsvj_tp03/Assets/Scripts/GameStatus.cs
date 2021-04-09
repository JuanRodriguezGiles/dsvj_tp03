using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameStatus : MonoBehaviour
{
    public bool playing = true;
    public int shotsLeft = 3;
    public int pinsLeft = 10;
    void Start()
    {

    }
    void Update()
    {
        if (shotsLeft == 0 || pinsLeft == 0)
            playing = false;
    }
}
