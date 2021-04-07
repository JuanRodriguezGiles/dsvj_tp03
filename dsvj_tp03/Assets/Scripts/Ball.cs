using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ball : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(hor, 0, 0);
        transform.position += direction * Time.deltaTime;
        if (transform.position.x <= -3f)
            transform.position = new Vector3(-3, transform.position.y, transform.position.z);
        if (transform.position.x >= 3f)
            transform.position = new Vector3(3, transform.position.y, transform.position.z);
    }
}
