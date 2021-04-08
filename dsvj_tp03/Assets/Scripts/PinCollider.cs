using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCollider : MonoBehaviour
{
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Pin")
            Debug.Log("asd");
    }
}
