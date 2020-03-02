using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [Header("Speed Range")]
    public float min = 3;
    public float max = 6;
    private float randomY;

    private Rigidbody2D rigidBody;

    private void Start()
    {
        randomY = -1 * Random.Range(min, max);
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(0, randomY);
    }

}
