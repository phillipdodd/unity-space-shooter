using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousVelocity : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity = speed;
    }
}
