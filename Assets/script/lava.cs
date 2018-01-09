using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava : MonoBehaviour {

    public int damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            var PlayerController = other.GetComponent<BallController>();
            if(PlayerController != null)
            {
                PlayerController.health -= damage;
            }
        }
    }
}
