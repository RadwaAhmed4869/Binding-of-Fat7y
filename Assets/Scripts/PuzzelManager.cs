using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class PuzzelManager : MonoBehaviour
{
    [SerializeField] private GroundSymbol[] groundSymbols;
    [SerializeField] private Image puzzelAnswer;
    [SerializeField] private GameObject timeManager;
    [SerializeField] private Timer timeManageObj;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private TextMeshProUGUI WinLoseText;
    [SerializeField] private Animator anim;

    [SerializeField] private AudioSource doorSound;
    int counter = 0;
    [SerializeField] private Light theLight;
    [SerializeField] Color transparentColor;
    [SerializeField] Color originalColor;
    [SerializeField] bool solved;

    public bool Solved { get => solved; private set => solved = value; }

    private void Start()
    {
        Solved = false;
        //puzzelAnswer.GetComponent<RawImage>().color = transparentColor;
        puzzelAnswer.gameObject.SetActive(false);
    }
    void Update()
    {
        Solved = check();
        //Debug.Log(Solved);

    }

    private bool check()
    {
        for(int i = 0; i < groundSymbols.Length; i++)
        {
            if(groundSymbols[i].puzzelSymbol != groundSymbols[i].correctSymbol)
            {
                return false;
            }
        }
        //puzzelAnswer.GetComponent<RawImage>().color = originalColor;
        if (timeManageObj.TimeRemaining == 0)
        {
            gameOver.SetActive(true);
            WinLoseText.text = "Game Over";
        }
        else
        {

            timeManager.gameObject.SetActive(true);
            puzzelAnswer.gameObject.SetActive(true);
            anim.SetBool("IsOpen", true);
            theLight.enabled = true;

            if (counter == 15)
            {
                
                doorSound.PlayOneShot(doorSound.clip, 0.7f);
            }
            counter++;
        }


        return true;
    }
}
