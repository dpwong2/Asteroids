using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour {
    //public GameObject ship;
    private Vector3 var;
	// Use this for initialization
	void Start () {
       // var = ship.transform.position;
        GetComponent<Rigidbody>().velocity = transform.forward * 10;
        GetComponent<Rigidbody>().AddTorque(transform.forward * 80);
        GetComponent<Rigidbody>().AddTorque(transform.up * 80);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ship")
            Destroy(other.gameObject);

    }
    // Update is called once per frame
    void Update () {
		
	}
}
