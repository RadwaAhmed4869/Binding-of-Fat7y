using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;
    [SerializeField] private PuzzelManager PManager;
    [SerializeField] private float timeRemaining = 10;
    [SerializeField] GameObject gameOver;
    [SerializeField] private bool timerIsRunning = false;

    private void Start()
    {
        gameOver.SetActive(false);
        PManager.GetComponent<PuzzelManager>();
        timerIsRunning = false;
    }

    void Update()
    {
        startTimer(PManager.Solved);
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void startTimer(bool pm)
    {

        if (pm)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);


                //timerText.color = Color.red;

            }
            else
            {
                gameOver.SetActive(true);
                Debug.Log("GameOver!");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collition");
        if (other.gameObject.CompareTag("Door") && PManager.Solved)
        {
            Debug.Log("win");
        }

    }

}
