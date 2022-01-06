using System;
using UnityEngine;

public class Clock : MonoBehaviour {
    const float degreesPerHour = 30f;
    const float degreesPerMinute = 6f;
    const float degreesPerSecond = 6f;

    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;

    public bool continuous;

    private void Update() {
        // Debug.Log(System.DateTime.Now.Hour);
        // Debug.Log(System.DateTime.Now.Minute);
        // Debug.Log(System.DateTime.Now.Second);

        if (continuous) {
            UpdateContinuous();
        } else {
            Updatediscrete();
        }
    }

    private void UpdateContinuous() {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation = 
            Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
        minutesTransform.localRotation = 
            Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
        secondsTransform.localRotation = 
            Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond, 0f);
    }

    private void Updatediscrete() {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = 
            Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = 
            Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = 
            Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);
    }
}
