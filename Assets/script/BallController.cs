using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    Rigidbody rb;
    public float speed;
    public int score;
    
    public int health;

    public float stamina;
    public float sprintmul;
    float finalspeed;

    public float jump;

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
        float up = Input.GetAxis("Jump");
        Vector3 move = new Vector3(horizontal, up, vertical);

        finalspeed += speed;

        if(Input.GetButtonDown("Return"))
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
