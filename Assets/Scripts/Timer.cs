using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currenttime;
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currenttime = countDown ? currenttime -= Time.deltaTime : currenttime += Time.deltaTime;
        if (hasLimit && ((countDown && currenttime <= timerLimit) ||(!countDown && currenttime >= timerLimit)))
        {
            currenttime = timerLimit;
            SetTimerText();
            timerText.color = Color.red;
            enabled = false;
        }

        SetTimerText();
        
    }

    private void SetTimerText()
    {
        timerText.text = currenttime.ToString("0.0");
    }
}
