using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleVelocity : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private Vector2 dir;

    public int speed;

    [Header("Wobble")]
    public float min = -1;
    public float max = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        dir = new Vector2(Random.Range(min, max), speed);
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity = dir;
    }
}
