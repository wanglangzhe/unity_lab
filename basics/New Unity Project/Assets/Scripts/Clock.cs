using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Update() {
        // Debug.Log(DateTime.Now.Hour);
        TimeSpan time = DateTime.Now.TimeOfDay;
		hoursPivot.localRotation =
			Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
		minutesPivot.localRotation =
			Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
		secondsPivot.localRotation =
			Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
