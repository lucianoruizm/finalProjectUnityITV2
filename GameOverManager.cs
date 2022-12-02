using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject GameOver;
    public static GameOverManager gameOverManager;

    void Start()
    {
        gameOverManager = this;
        GameOver.SetActive(false);
    }

    public void CallGameOver()
    {
        GameOver.SetActive(true);
    }
}
