using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public Vector3 cameraPosition;

    // Update is called once per frame
    void Update()
    {
        cameraPosition = 
        transform.position = new Vector3(target.position.x + 10, transform.position.y, transform.position.z);
    }
}
