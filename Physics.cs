using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {
    public GameObject ship;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(ship.transform);
    }
}
