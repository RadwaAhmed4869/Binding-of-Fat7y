using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tutorial : MonoBehaviour
{
    [SerializeField] private Image tut;

    private void Start()
    {
        tut.gameObject.SetActive(false);
        StartCoroutine(tutorialfunc());
    }
    IEnumerator tutorialfunc()
    {
        tut.gameObject.SetActive(true);
        yield return new WaitForSeconds(5);
        tut.gameObject.SetActive(false);
    }
}
