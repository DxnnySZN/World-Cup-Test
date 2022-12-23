using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script allows the camera to follow the user wherever it goes
public class CameraController : MonoBehaviour
{
    public Transform target;
    Vector3 offset;

    // Start is called before the first frame update
    void Start(){
        offset = target.position - transform.position;
        // offset is the distance between the target position and the camera position
    }

    private void FixedUpdate(){
        transform.position = target.position - offset;
        // the camera will now follow the target with respect to the offset
    }
}