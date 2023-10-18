using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    Camera playercam;
    bool camOn = false;

    float speedH = 5.0f;
    float speedV = 5.0f;

    float yaw = 0.0f;
    float pitch = 0.0f;


    void Start()
    {
        playercam = GetComponent<Camera>();
    }

    void Update()
    {
        SwitchCamera(playercam);

        if (camOn)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }

    void SwitchCamera(Camera playerCam)
    {
        if (!camOn && Input.GetKeyDown(KeyCode.Space)) { playercam.enabled = true; camOn = true; }
        else if (camOn && Input.GetKeyDown(KeyCode.Space)) { playercam.enabled = false; camOn = false; }
    }
}
