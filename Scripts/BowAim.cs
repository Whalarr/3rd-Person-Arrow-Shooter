using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowAim : MonoBehaviour {

    bool IsAiming;
    public Transform FirePoint;
    public Camera Player_Camera;
    vThirdPersonCamera Player_cam;

    // Use this for initialization
    void Start ()
    {
       Player_cam = Player_Camera.GetComponent<vThirdPersonCamera>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Updatefire();
        PlayerAiming();

	}

    void Updatefire()
    {
        FirePoint.rotation = Player_Camera.transform.rotation;
    }

    void PlayerAiming()
    {
        if(Input.GetMouseButton(1))
        {
            Debug.Log("Player is aiming");
            Player_cam.rightOffset = 0.35f;
            Player_cam.defaultDistance = 1.0f;
        }
        if(Input.GetMouseButtonUp(1))
        {
            Player_cam.rightOffset = 0.1f;
            Player_cam.defaultDistance = 2.5f;
        }
    }
}
