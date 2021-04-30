using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransitions : MonoBehaviour
{
    public Transform body, face;
    public float speed;
    Transform currentView;


    // Start is called before the first frame update
    void Start()
    {
        currentView = body;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentView = body;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentView = face;
        }
    }

    public void CameraBodyView()
    {
        currentView = body;
    }
    public void CameraFaceView()
    {
        currentView = face;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //position Anim
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * speed);
        //rotation Anim
        Vector3 current_angle = new Vector3(Mathf.LerpAngle(transform.rotation.eulerAngles.x,currentView.transform.rotation.eulerAngles.x, Time.deltaTime*speed), Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * speed), Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * speed));

        transform.eulerAngles = current_angle;

    }
}
