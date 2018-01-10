using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour {

    public GameObject Player;
    public int score;
    Vector3 pos;

	// Use this for initialization
	void Start () {
        Vector3 pos = new Vector3(-100, -100, -100);
    }
	
	// Update is called once per frame
	void Update () {
        BallController player = Player.GetComponent<BallController>();
        if(player.score >= score)
        {
            transform.position = pos;
        }
    }
}
