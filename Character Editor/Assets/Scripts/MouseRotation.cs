using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    float speed = 10;
    private void Start()
    {
        Debug.Log("hi");
    }
    void OnMouseDrag()
    {
        Debug.Log("Dragged");
        float rotX = Input.GetAxis("Mouse X") * speed;
        float rotY = Input.GetAxis("Mouse Y") * speed;

        transform.Rotate(Vector3.down, rotX);
        transform.Rotate(Vector3.right, rotY);
    }
}
