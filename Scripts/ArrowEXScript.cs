using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowEXScript : MonoBehaviour {

    public ParticleSystem Exp_Particle;
    bool has_Explode = false;

    public float blast_force;
    public float blast_rad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(has_Explode == true)
        {
            Destroy(this.gameObject);
        }
	}



    private void OnCollisionEnter(Collision collision)
    {
        Explode();
    }

    void Explode()
    {
        Exp_Particle.Play();
       

        Collider[] colliders = Physics.OverlapSphere(transform.position, blast_rad);

        foreach(Collider Nearby in colliders)
        {
            Rigidbody rb = Nearby.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(blast_force,transform.position,blast_rad);
            }
        }

        has_Explode = true;
    }
}
