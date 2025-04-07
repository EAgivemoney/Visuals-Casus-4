using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI clockText;

    private float elapsedTime = 0f;
    private const float maxTime = 90 * 60f;
    private bool isPaused = false;

    void Start()
    {
        elapsedTime = UnityEngine.Random.Range(0f, maxTime);
        UpdateClockText();
    }

    void Update()
    {
        if (isPaused)
            return;

        elapsedTime += Time.deltaTime;

        if (elapsedTime >= maxTime)
        {
            elapsedTime = maxTime;
            isPaused = true;
        }

        UpdateClockText();
    }

    private void UpdateClockText()
    {
        int hours = Mathf.FloorToInt(elapsedTime / 3600f);
        int minutes = Mathf.FloorToInt((elapsedTime % 3600f) / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);

        string timeString = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);

        clockText.text = timeString;
    }

    public void ResetTimer()
    {
        elapsedTime = UnityEngine.Random.Range(0f, maxTime);
        isPaused = false;
        clockText.text = "00:00:00";
    }
}
