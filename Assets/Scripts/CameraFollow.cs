using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    [SerializeField] private float cameraSpeed=2;
    public Vector3 offset;

    void Update()
    {
        transform.position=Vector3.Lerp(transform.position,target.position+offset,Time.deltaTime*cameraSpeed);
    }
}
