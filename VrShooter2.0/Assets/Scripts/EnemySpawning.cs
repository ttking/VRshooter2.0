using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour {

    public GameObject Enemy;
    public Transform[] spawnLocation;
    public float spawnTime = 5f;
	
	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);	
	}
	
	
	void Spawn()
    {
        int spawnLocationIndex = Random.Range(0, spawnLocation.Length);
        Instantiate(Enemy, spawnLocation[spawnLocationIndex].position, spawnLocation[spawnLocationIndex].rotation);
    }
}
