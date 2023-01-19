using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    [SerializeField] private GameObject GameWinner;
    void Start()
    {

        GameWinner.SetActive(false);
    }

    public void MainMenu()
    {

        SceneManager.LoadScene("MainMenu");
    }

    public void RestartGame()
    {

        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {

        Application.Quit();
    }
}
