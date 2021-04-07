using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    ConstantForce force;
    void Start()
    {
        force = GetComponentInChildren<ConstantForce>();
        force.force = new Vector3(0, 0, 1);
    }
    void Update()
    {
       
    }
}
