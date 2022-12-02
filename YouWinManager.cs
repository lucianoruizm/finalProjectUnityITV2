using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWinManager : MonoBehaviour
{
    public GameObject YouWin;
    public static YouWinManager youWinManager;

    void Start()
    {
        youWinManager = this;
        YouWin.SetActive(false);
    }

    public void CallYouWin()
    {
        YouWin.SetActive(true);
    }
}