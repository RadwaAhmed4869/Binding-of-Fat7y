using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Image tut;
    private void Start()
    {
        tut.gameObject.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(tutorial());
    }

    public void QuitGame()
    {
        Application.Quit();  
    }

    IEnumerator tutorial()
    {
        tut.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        tut.gameObject.SetActive(false);
    }

}
