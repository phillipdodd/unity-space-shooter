using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (!collision.gameObject.name.Contains("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
