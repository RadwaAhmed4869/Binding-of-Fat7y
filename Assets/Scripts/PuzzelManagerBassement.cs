using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class PuzzelManagerBassement : MonoBehaviour
{
    [SerializeField] private GroundSymbol[] groundSymbols;
    [SerializeField] private GameObject GameWin;
    //[SerializeField] private AudioSource audioSource;
    //[SerializeField] private AudioClip doorSound;

    [SerializeField] bool solved;

    public bool Solved { get => solved; private set => solved = value; }

    private void Start()
    {
        
        //audioSource = GetComponent<AudioSource>();
        //puzzelAnswer.GetComponent<RawImage>().color = transparentColor;
        //puzzelAnswer.gameObject.SetActive(false);
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

            GameWin.SetActive(true);



        return true;
    }
}
