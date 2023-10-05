using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MinigameManager : MonoBehaviour
{
    public abstract void Show();

    public abstract void Hide();


    public abstract void OnGameStart();


    public abstract void OnGameDone();
    
    public abstract void CheckWin();
}
