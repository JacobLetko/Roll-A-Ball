using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour {

    public Text timerLable;
    public float duration;
	
	// Update is called once per frame
	void Update ()
    {
        duration -= Time.deltaTime;

        int temp = (int)duration;

        int hours = temp / 60 / 60;
        int min = temp / 60;
        int sec = temp % 60;

        timerLable.text = hours.ToString() + ":" + min.ToString() + ":" + sec.ToString();
	}

}
