using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUB : MonoBehaviour
{
    public BallController playerBall;


    public Text scoreLable;

    public Text timerLable;
    public float duration;

    public Text speed;
    private Rigidbody playerRigidbody;

    private void Start()
    {
        playerRigidbody = playerBall.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreLable.text = playerBall.score.ToString("D4");

        duration -= Time.deltaTime;
        int temp = (int)duration;
        int hours = temp / 60 / 60;
        int min = temp / 60;
        int sec = temp % 60;
        timerLable.text = hours.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2");

        Vector3 velocity = playerRigidbody.velocity;
        velocity.y = 0.0f;
        speed.text = (int)velocity.magnitude + "m/s";
    }
}
