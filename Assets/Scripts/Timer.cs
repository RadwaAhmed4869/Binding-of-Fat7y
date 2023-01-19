using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float timeRemaining;
    [SerializeField] private bool timerIsRunning = false;

    public float TimeRemaining { get => timeRemaining; set => timeRemaining = value; }
    public bool TimerIsRunning { get => timerIsRunning; set => timerIsRunning = value; }

    private void Start()
    {
        timeRemaining = 25;
        timerText.gameObject.SetActive(true);
        // Starts the timer automatically
        //theLight.gameObject.SetActive(false);
        TimerIsRunning = true;
    }
    void Update()
    {
        if (TimerIsRunning)
        {
            if (TimeRemaining > 0)
            {
                TimeRemaining -= Time.deltaTime;
                DisplayTime(TimeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                TimeRemaining = 0;
                TimerIsRunning = false;
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }



}
