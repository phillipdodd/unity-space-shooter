using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject pauseMenuUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && GameOverMenuController.isGameOver == false)
        {
            if (isGamePaused) 
            { Resume(); } 
            else 
            { Pause(); }
        }
    }

    private void Pause()
    {
        Time.timeScale = 0f;
        isGamePaused = true;
        pauseMenuUI.SetActive(true);
    }

    // Resume and Quit are public to be used by menu buttons
    private void Resume()
    {
        Time.timeScale = 1f;
        isGamePaused = false;
        pauseMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void SelfDestruct()
    {
        GameObject[] ships = GameObject.FindGameObjectsWithTag("Ship");
        foreach (GameObject ship in ships)
        { Destroy(ship); }
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

    }
}
