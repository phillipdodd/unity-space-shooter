using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenuController : MonoBehaviour
{
    public static bool isGameOver = false;
    public GameObject gameOverMenuUI;
    public GameObject playerSpawner;

    private Spawn spawn;

    private void Start()
    {
        spawn = playerSpawner.GetComponent<Spawn>();
    }

    private void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quitting Game...");
            Application.Quit();
        }    
    }

    // Called by PlayerDeath
    public void GameOver()
    {
        Debug.Log("Game Over!");
        Debug.Log(gameOverMenuUI);
        Time.timeScale = 0f;
        isGameOver = true;
        gameOverMenuUI.SetActive(true);
        //gameOverMenuUI.gameObject.SetActive(true);

        ScoreController.Instance.ClearScore();
    }

    public void PlayerContinue()
    {
        Time.timeScale = 1f;
        isGameOver = false;
        GameObject[] ships = GameObject.FindGameObjectsWithTag("Ship");
        foreach (GameObject ship in ships)
        { Destroy(ship); }
        spawn.Invoke("SpawnNext", 0.5f);
        gameOverMenuUI.SetActive(false);

    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
