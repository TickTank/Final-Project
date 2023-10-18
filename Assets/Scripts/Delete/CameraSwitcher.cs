using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset = Vector3.up;
    private Camera cam;
    private bool playerCam = false;

    void Start()
    {
        player = GameObject.Find("Player");
        cam = player.GetComponent<Camera>();
    }

    void Update()
    {       
        if (!playerCam && Input.GetKeyDown(KeyCode.Space)) {  cam.gameObject.SetActive(true); playerCam = true; }
        else if (playerCam && Input.GetKeyDown(KeyCode.Space)) { cam.gameObject.SetActive(false); playerCam = false; }
    }
}
