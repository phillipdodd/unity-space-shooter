using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour
{
    private void OnDestroy()
    {
        ScoreController.Instance.UpdateScore();
    }
}
