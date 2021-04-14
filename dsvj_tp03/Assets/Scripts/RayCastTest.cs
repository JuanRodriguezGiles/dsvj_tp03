using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RayCastTest : MonoBehaviour
{
    private Camera mainCamera;
    public GameObject cubeGameObject;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        Vector3 mousePos = Input.mousePosition;
        Ray ray = mainCamera.ScreenPointToRay(mousePos);
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.yellow);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 200))
            {
                if (hit.collider.gameObject.tag == "Ball")
                {
                    Destroy(hit.collider.gameObject);
                    GameManagerTest gm = FindObjectOfType<GameManagerTest>();
                    gm.AddScore(20);
                }
                else
                    Instantiate(cubeGameObject, hit.point, Quaternion.identity);
            }
        }
    }
}
