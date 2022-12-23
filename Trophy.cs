using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script constantly rotates the trophy until it has been collected by the user
public class Trophy : MonoBehaviour
{
    public float rotateSpeed;
    
    private void FixedUpdate(){
        transform.Rotate(0, rotateSpeed, 0);
    }
}