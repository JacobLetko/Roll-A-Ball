using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawn : MonoBehaviour {

    public GameObject PickUp;
    public float spawnInterval;
    float SpawnTimer;
    public float range;

	// Use this for initialization
	void Start () {
        SpawnTimer = 0;
	}

    void spawnPickUp()
    {
        GameObject spawnedPickUp = Instantiate(PickUp);
        float randomX = Random.Range(-range, range);
        float randomY = Random.Range(-range, range);
        spawnedPickUp.transform.position = transform.position + new Vector3(randomX, 0, randomY);
    }
	
	// Update is called once per frame
	void Update () {
        SpawnTimer -= Time.deltaTime;
        if(SpawnTimer <= 0)
        {
            spawnPickUp();
            SpawnTimer = spawnInterval;
        }
	}
}
