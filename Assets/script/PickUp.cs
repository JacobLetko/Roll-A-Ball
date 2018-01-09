using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public int scoreAdded;
    public float rotation;
    public float life;
    float lifeTimer;

	// Use this for initialization
	void Start () {
        lifeTimer = life;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotation, 0, rotation / 3);
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0)
            Destroy(gameObject);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            var PlayerController = other.GetComponent<BallController>();
            if(PlayerController != null)
            {
                PlayerController.score += scoreAdded;
                Destroy(gameObject);
            }
        }
    }
}
