using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bowFire : MonoBehaviour {

    public AudioSource WeaponSwitch_AUD;
    public AudioClip WeaponSwitch_CLIP;
    public Text AmmoText;

    public int Arrowtype_num = 1;
    public GameObject[] Arrow_Types;
    public Rigidbody Selected_Arrow;
    bool CanFire;
    bool isFiring;
    public Transform Firepoint;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {      
        FireBow();
        
        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            

            if (Arrowtype_num >= Arrow_Types.Length)
            {
                Arrowtype_num = 1;
            }
            else
                Arrowtype_num++;
            Arrow_Switch();

        }


        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {


            if (Arrowtype_num <= 1)
            {
                Arrowtype_num = Arrow_Types.Length;
            }
            else
                Arrowtype_num--;
            Arrow_Switch();

        }

    }

    void FireBow()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //if (Canfire == true)
            //{

                Debug.Log("Player is Firing!");
                Rigidbody Arrow_instance;
                Arrow_instance = Instantiate(Selected_Arrow, Firepoint.position, Firepoint.rotation) as Rigidbody;
                Arrow_instance.AddForce(Firepoint.forward * 300);
                isFiring = true;
          //  }
        }
        if (Input.GetMouseButtonUp(0))
        {
            isFiring = false;
        }
    }

    void Arrow_Switch()
    {
        WeaponSwitch_AUD.PlayOneShot(WeaponSwitch_CLIP);
        
        if (Arrowtype_num == 1)
        {
            Selected_Arrow = Arrow_Types[0].GetComponent<Rigidbody>();
            AmmoText.text = "Standard";
        }
        if (Arrowtype_num == 2)
        {
            Selected_Arrow = Arrow_Types[1].GetComponent<Rigidbody>();
            AmmoText.text = "Fire";
        }
        if (Arrowtype_num == 3)
        {
            Selected_Arrow = Arrow_Types[2].GetComponent<Rigidbody>();
            AmmoText.text = "Light";
        }
        if (Arrowtype_num == 4)
        {
            Selected_Arrow = Arrow_Types[3].GetComponent<Rigidbody>();
            AmmoText.text = "Explode";
        }


    }
}
