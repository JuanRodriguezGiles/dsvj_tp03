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
                do
                {
                    newPosVector3.x = Random.Range(-2f, 2f);
                    newPosVector3.y = 1.2f;
                    newPosVector3.z = Random.Range(0, 30);
                } while (!isPosValid(newPosVector3));

                t.position = newPosVector3;
            }
        }
    }
    bool isPosValid(Vector3 pos)
    {
        foreach (var t in pinsTransforms)
        {
            if (pos.x >= t.position.x - 0.5f && pos.x <= t.position.x + 0.5f && pos.z >= t.position.z - 0.5f &&
                pos.z <= t.position.z + 0.5f)
                return false;
        }

        return true;
    }
}