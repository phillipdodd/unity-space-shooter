using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemy : MonoBehaviour
{
    // Bullet prefab
    public GameObject bullet;

    [Header("Bullet Interval")]
    public float min = 2;
    public float max = 3;

    private Collider2D enemyCollider;

    private void Start()
    {
        enemyCollider = transform.parent.GetComponent<Collider2D>();
        Invoke("Fire", Random.Range(min, max));
    }

    private void Fire()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
        // IgnoreCollisionLayer()?
        // This script is intended for children of enemy (transform.parent)
        Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(), enemyCollider);
        Invoke("Fire", Random.Range(min, max));
    }

}
