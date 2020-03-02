using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreObject;

    private int _score = 0;
    public int score
    {
        get { return _score; }
        set
        {
            if (_score != value)
            {
                _score = value;
                if (scoreObject != null) scoreObject.text = _score.ToString();
            }
        }
    }

    #region Singleton
    public static ScoreController Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    // Used by ScoreOnDestroy
    public void UpdateScore()
    {
        score++;
    }

    // Used by GameOverMenuController
    public void ClearScore()
    {
        score = 0;
    }

}
