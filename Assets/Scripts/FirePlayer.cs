using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{
    // Holds actual prefab
    public GameObject bullet;

    private Collider2D playerCollider;

    private void Start()
    {
        // This script is intended for children of PlayerShip (transform.parent)
        playerCollider = transform.parent.GetComponent<Collider2D>();
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Space) ||
        //    Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(0))
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) && PauseMenuController.isGamePaused == false)
        //if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))

        {
                GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);

            Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(), playerCollider);
        }
    }
}
