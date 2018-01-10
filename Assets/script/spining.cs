using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spining : MonoBehaviour {

    public float rotate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,rotate,0);
	}
}
