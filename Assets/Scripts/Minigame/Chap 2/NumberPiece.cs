using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NumberPiece : MonoBehaviour
{
    public int id, xDir, yDir;
    private NumberPuzzle minigameManager;

    private void Awake()
    {
        minigameManager = GetComponentInParent<NumberPuzzle>();
    }

    public void Setup(int id, int xDir, int yDir)
    {
        this.id = id;
        this.xDir = xDir;
        this.yDir = yDir;
    }
    
    public void OnMouseDown()
    {
        minigameManager.TurnIn(this);
    }
    
}
