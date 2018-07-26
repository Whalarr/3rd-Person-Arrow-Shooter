using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyScript : MonoBehaviour {


    public GameObject _Ragdoll;


	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if(collision.collider.tag == "Arrow")
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Dummy has been killed");
        
        Instantiate(_Ragdoll, this.transform.position, this.transform.rotation);
        Destroy(gameObject);
       
    }

}
