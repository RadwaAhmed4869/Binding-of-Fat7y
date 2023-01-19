using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RoomOne : MonoBehaviour
{
    //[SerializeField] private GameObject timeManager;
    [SerializeField] private Timer timeManageObj;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject imageMessage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RoomOne"))
        {
            
            //timeManager.gameObject.SetActive(false);
            timeManageObj.TimerIsRunning = false;
            timerText.gameObject.SetActive(false);
            timeManageObj.TimeRemaining = 15;
            imageMessage.gameObject.SetActive(false);
            Debug.Log("finished Room one");
        }
    }
}
