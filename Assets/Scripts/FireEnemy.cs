using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemy : MonoBehaviour
{
    public GameObject bullet;

    [TitleGroup("Bullet Interval")]
    public float min = 0.5f;
    [TitleGroup("Bullet Interval")]
    public float max = 1.5f;

    private Collider2D enemyCollider;

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(8, 8);
        enemyCollider = transform.parent.GetComponent<Collider2D>();
        Invoke("Fire", Random.Range(0.2f, 0.5f));
    }

    private void Fire()
    {
        // Only spawn if parent enemy still exists
        if(transform.parent)
        {
            GameObject g = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
            Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(), enemyCollider);
            Invoke("Fire", Random.Range(min, max));
        }   
    }

}
