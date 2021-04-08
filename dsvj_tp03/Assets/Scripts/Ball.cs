using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ball : MonoBehaviour
{
    public float force = 0f;
    private bool rolling = false;
    void Start()
    {
        GetComponent<ConstantForce>();
    }
    void Update()
    {
        if (!rolling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rolling = true;
                GetComponent<ConstantForce>().force = new Vector3(0, 0, force);
                return;
            }

            float hor = Input.GetAxis("Horizontal");
            Vector3 direction = new Vector3(hor, 0, 0);
            transform.position += direction * Time.deltaTime;
            if (transform.position.x <= -3f)
                transform.position = new Vector3(-3, transform.position.y, transform.position.z);
            if (transform.position.x >= 3f)
                transform.position = new Vector3(3, transform.position.y, transform.position.z);

            force += Input.GetAxis("Vertical") / 50;
            if (force < 0)
                force = 0;
        }
    }
}
