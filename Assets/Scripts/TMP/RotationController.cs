using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    void Update()
    {
        Vector3 MouseInWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MouseInWorldPosition.z= -(transform.position.x - Camera.main.transform.position.x);
        transform.rotation=Quaternion.LookRotation(Vector3.forward,MouseInWorldPosition-transform.position); 
        //transform.LookAt(MouseInWorldPosition,Vector3.up);
    }
}
