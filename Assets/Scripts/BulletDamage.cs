using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class BulletDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // FirePlayer is already setting its spawned bullets to ignore itself
        if (collision.gameObject.CompareTag("Ship"))
        {
            // Destroy target
            collision.gameObject.transform.DOScale(0, 0.25f).OnComplete((() => { Destroy(collision.gameObject); }));
            
            // Destroy Bullet
            Destroy(gameObject);

            // Update Score if Enemy destroyed
            if (!collision.gameObject.name.Contains("Player"))
            {
                ScoreController.Instance.UpdateScore();
            }
        }
    }
}
