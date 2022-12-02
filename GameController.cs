using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    public bool youWin;

    int _score = 0;
    
    void Update()
    {
        scoreText.text = _score.ToString();
    }

    public void ScoreUp(int score)
    {
        _score += score;
        
        if(_score == 50)
        {
            Debug.Log("You Win");
            youWin = true;
            YouWinManager.youWinManager.CallYouWin();
        }
    }

}