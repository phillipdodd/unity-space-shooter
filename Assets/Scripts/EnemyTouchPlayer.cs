using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class EnemyTouchPlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            collision.transform.DOScale(0, 0.25f).OnComplete((() => { Destroy(collision.gameObject); }));
        }
    }
}
