using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float timeRemaining = 10;
    [SerializeField] private bool timerIsRunning = false;

    public float TimeRemaining { get => timeRemaining; set => timeRemaining = value; }

    private void Start()
    {
        timerText.gameObject.SetActive(true);
        // Starts the timer automatically
        //theLight.gameObject.SetActive(false);
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
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
                timerIsRunning = false;
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
