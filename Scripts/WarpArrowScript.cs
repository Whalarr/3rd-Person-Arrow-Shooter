using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpArrowScript : MonoBehaviour {

    GameObject Player;
    Transform Player_transform;


	// Use this for initialization
	void Start ()
    {
        Debug.Log("Warp arrow fired!");
        Player = FindObjectOfType<vThirdPersonCamera>().gameObject;
        Player_transform = Player.transform;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.transform.position);


        if (collision.collider.tag == "Wall")
        {
            Debug.Log("Warp arrow has collided with a wall ");
            WarpToLocation();
        }

        if (collision.collider.tag == "Floor")
        {
            Debug.Log("Warp arrow has collided with a Floor");
            WarpToLocation();
        }
    }
    
    void WarpToLocation()
    {
        Debug.Log("Player has warped");
        Player_transform.position = gameObject.transform.position;
        Destroy(gameObject);
    }

}
