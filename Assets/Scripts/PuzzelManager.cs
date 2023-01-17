using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class PuzzelManager : MonoBehaviour
{
    [SerializeField] private GroundSymbol[] groundSymbols;
    [SerializeField] private RawImage puzzelAnswer;
    [SerializeField] Color transparentColor;
    [SerializeField] Color originalColor;

    bool solved;

    private void Start()
    {
        solved = false;
        //puzzelAnswer.GetComponent<RawImage>().color = transparentColor;
        puzzelAnswer.gameObject.SetActive(false);
    }
    void Update()
    {
        solved = check();
        Debug.Log(solved);

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

        puzzelAnswer.gameObject.SetActive(true);

        return true;
    }
}
