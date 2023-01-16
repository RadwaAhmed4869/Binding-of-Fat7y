using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PuzzelManager : MonoBehaviour
{
    [SerializeField] private GroundSymbol[] groundSymbols;
    bool solved;

    private void Start()
    {
        solved = false;
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
        return true;

    }
}
