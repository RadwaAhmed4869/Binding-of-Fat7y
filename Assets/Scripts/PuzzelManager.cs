using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class PuzzelManager : MonoBehaviour
{
    [SerializeField] private GroundSymbol[] groundSymbols;
    //[SerializeField] private RawImage puzzelAnswer;
    [SerializeField] private Image puzzelAnswer;
    [SerializeField] private GameObject timeManager;
    [SerializeField] private Timer timeManageObj;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private TextMeshProUGUI WinLoseText;
    [SerializeField] private Animator anim;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip doorSound;
    [SerializeField] private Light theLight;
    [SerializeField] Color transparentColor;
    [SerializeField] Color originalColor;
    [SerializeField] bool solved;

    /*                anim.StartPlayback();
                theLight.gameObject.SetActive(true);*/
    public bool Solved { get => solved; private set => solved = value; }

    private void Start()
    {
        Solved = false;
        audioSource = GetComponent<AudioSource>();
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
            //gameOver.SetActive(true);
            //WinLoseText.text = "Winner";
            timeManager.gameObject.SetActive(true);
            puzzelAnswer.gameObject.SetActive(true);
            anim.SetBool("IsOpen", true);
            theLight.enabled = true;
            audioSource.PlayOneShot(doorSound, 0.7F);
        }


        return true;
    }
}
