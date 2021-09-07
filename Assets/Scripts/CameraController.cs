using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    //same as update run by frame by frame, but run after update method and other updates
    private void LateUpdate(){
        Vector3 newPos = target.position + offset;
        newPos.z = transform.position.z;
        transform.position = newPos;
    }
}
