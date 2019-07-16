using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    //code used from unity tutorials
    //public PlayerHealth playerHealth;       // Reference to the player's heatlh.
    public GameObject enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 300f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    public GameObject ship;
    public Transform shipr;
                                            // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    
    // Update is called once per frame
    void Spawn () {
        
       // shipr = ship.transform;
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        //enemy.GetComponent<Rigidbody>().velocity = enemy.transform.forward * 10;
        //Quaternion.LookRotation(ship.transform.position)
    }
}
