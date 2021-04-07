using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.transform.rotation.eulerAngles.x);
        if (transform.rotation.eulerAngles.x >= 80 )
            Debug.Log("cai2");
        if (transform.rotation.eulerAngles.z >= 80)
            Debug.Log("cai2");
    }
}