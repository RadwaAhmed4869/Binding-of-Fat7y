using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject Gamever;
    void Start()
    {
        
        Gamever.SetActive(false);
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
