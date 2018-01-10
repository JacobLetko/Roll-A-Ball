using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        BallController player = other.GetComponent<BallController>();
        if(player != null)
        {
            player.location = transform.position;
        }
    }
}
