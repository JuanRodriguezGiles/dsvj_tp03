using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PinRandomizer : MonoBehaviour
{
    public GameObject ball;
    private Ball ballScript;
    public List<Transform> pinsTransforms;
    void Start()
    {
        ballScript = ball.GetComponent<Ball>();
    }
    void Update()
    {
        if (!ballScript.rolling && Input.GetKeyDown(KeyCode.P))
        {
            foreach (var t in pinsTransforms)
            {
                Vector3 newPosVector3;
                newPosVector3.x = Random.Range(-2f, 2f);
                newPosVector3.y = 1.2f;
                newPosVector3.z = Random.Range(0,30);
                t.position = newPosVector3;
            }
        }
    }
}
