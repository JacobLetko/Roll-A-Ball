using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Rigidbody rb;
    public float speed;
    public int score;
    
    public int health;

    public float stamina;
    public float sprintmul;
    float finalspeed;

    public float jump;
    public bool jumpA;

    public Vector3 location;

	// Use this for initialization
	void Start ()
    {
    
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, 0, vertical);

        finalspeed += speed;

        if(Input.GetButtonDown("return"))
        {
            transform.position = location;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += transform.up * jump * Time.deltaTime;
        }

            rb.AddForce(move * speed * Time.deltaTime);
        if (stamina < 100 && Input.GetButtonUp("Sprint"))
        {
            stamina += Time.deltaTime / 2;
        }
	}
}
