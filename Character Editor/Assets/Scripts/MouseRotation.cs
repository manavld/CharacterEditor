using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    float speed = 10;
  
    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * speed;
        float rotY = Input.GetAxis("Mouse Y") * speed;

        transform.Rotate(Vector3.down, rotX);
        transform.Rotate(Vector3.right, -rotY);
    }

    public void onResetRotation()
    {
        transform.localEulerAngles = new Vector3(0, 165, 0);
    }
}
