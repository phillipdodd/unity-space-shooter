using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public float endGameDelay = 0.5f;
    private GameOverMenuController gameOverMenu;

    private void Start()
    {
        gameOverMenu = GameObject.Find("GameOverMenu").GetComponent<GameOverMenuController>();
    }

    private void OnDestroy()
    {
        // Todo have this reference acquired some other way
        gameOverMenu.Invoke("GameOver", endGameDelay);
    }
}
