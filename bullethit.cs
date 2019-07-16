using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullethit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Rock")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
