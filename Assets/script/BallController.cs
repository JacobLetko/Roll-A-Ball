using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Rigidbody rb;
    public float speed;
    public int score;
    public float stamina;
    public int health;
    public float sprintmul;
    float finalspeed;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, 0, vertical);

        float sprintval = Input.GetAxis("Sprint");
        bool sprint = sprintval != 0.0f;//&&stamina > 0;

        finalspeed += speed;

        if (sprint)
        {
            finalspeed *= sprintmul;
        }

            rb.AddForce(move * speed * Time.deltaTime);
        if (stamina <= 100 && Input.GetKeyUp(KeyCode.LeftShift))
        {
            stamina += Time.deltaTime / 2;
        }
	}
}
