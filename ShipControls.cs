using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour {
    // some code from unity documentation and Forums
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public Rigidbody rb;
	public float thrust;
	private Vector3 Playerpos;
    
    
	// Use this for initialization
	void Start () {
		 rb = GetComponent<Rigidbody>();
		 thrust =2f;
		 Playerpos=transform.position;
        //Instantiate(firethrust, bulletSpawn.position, bulletSpawn.rotation);
        //firethrust.GetComponent<Renderer>().enabled = false;
        //firepurple = transform.GetChild(1);
        GameObject.Find("firee").GetComponent<Renderer>().material.color =Color.clear;
        
    }
	
	// Update is called once per frame
	void Update () {
		float input = Input.GetAxis("Horizontal");
        
		Playerpos=transform.position;
		if (Input.GetAxis("Vertical")>0)
		{
            
            //GameObject.Find("purpleFire").SetActive(true);
            //firethrust.GetComponent<Renderer>().enabled = true;
            if (rb.drag>0)
			{rb.drag-=.2f;}
			rb.AddForce( transform.forward * thrust);
			if(thrust<=4)
			{thrust+= .5f;}
            GameObject.Find("firee").GetComponent<Renderer>().material.color = Color.red;
        }
		else
		{
            GameObject.Find("firee").GetComponent<Renderer>().material.color = Color.clear;
            thrust =2f;
			if(rb.drag<3)
			{rb.drag+=.02f;}
            //GameObject.Find("purpleFire").SetActive(false);
        }
		transform.Rotate(new Vector3(0f, input * 3f, 0f));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

    }// update method end
    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position ,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 3.0f);
    }
}
