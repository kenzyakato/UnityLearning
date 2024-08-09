using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform hoursPivot, minutesPivot, secondsPivot;

    private void Update()
    {
        var time = DateTime.Now;
        //Debug.Log(DateTime.Now.Hour);
        const float hoursToDegrees = -30f, minutesToDegress = -6f, secondsToDegrees = -6f;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegress * time.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }
}