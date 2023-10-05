using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class NumberPuzzle : MinigameManager
{
    [ShowInInspector] private NumberPiece[,] matrix = new NumberPiece [3,3];

    public override void Show()
    {
        throw new System.NotImplementedException();
    }

    public override void Hide()
    {
        throw new System.NotImplementedException();
    }

    public override void OnGameStart()
    {
        throw new System.NotImplementedException();
    }

    public override void OnGameDone()
    {
        throw new System.NotImplementedException();
    }

    public override void CheckWin()
    {
        if (CheckIfCorrect())
            OnGameDone();
    }


    private bool CheckIfCorrect()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                var idNeed = 3 * i + j; 
                if (idNeed is 8)
                    break; 
                if (matrix[i,j].id != idNeed)
                {
                    return false; 
                }
            }
        }
        return true;
    }

    public void Suff()
    {
        
    }

    private int GetEmptySlot(int i, int j)
    {
        // return -1 if not found , 0 if left, 1 if right, 2 if up, 3 if down
        
        // check left
        if (j - 1 >= 0 && matrix[i, j - 1] is null)
            return 0;
        // check right
        if (j + 1 < 3 && matrix[i, j + 1] is null)
            return 1;
        // check up
        if (i - 1 >= 0 && matrix[i - 1, j] is null)
            return 2;
        // check down
        if (i + 1 < 3 && matrix[i + 1, j] is null)
            return 3;
        
        return -1; 
    }

    public void TurnIn(NumberPiece numberPiece)
    {
        var p = GetEmptySlot(numberPiece.xDir, numberPiece.yDir);
        if (p is -1)
            return; 
        switch (p)
        {
            case 0:
                numberPiece.transform.position = matrix[numberPiece.xDir, numberPiece.yDir - 1].transform.position;
                matrix[numberPiece.xDir, numberPiece.yDir - 1] = numberPiece;
                matrix[numberPiece.xDir, numberPiece.yDir] = null;
                numberPiece.yDir -= 1;
                break;
            case 1:
                numberPiece.transform.position = matrix[numberPiece.xDir, numberPiece.yDir + 1].transform.position;
                matrix[numberPiece.xDir, numberPiece.yDir + 1] = numberPiece;
                matrix[numberPiece.xDir, numberPiece.yDir] = null;
                numberPiece.yDir += 1;
                break;
            case 2:
                numberPiece.transform.position = matrix[numberPiece.xDir - 1, numberPiece.yDir].transform.position;
                matrix[numberPiece.xDir - 1, numberPiece.yDir] = numberPiece;
                matrix[numberPiece.xDir, numberPiece.yDir] = null;
                numberPiece.xDir -= 1;
                break;
            case 3:
                numberPiece.transform.position = matrix[numberPiece.xDir + 1, numberPiece.yDir].transform.position;
                matrix[numberPiece.xDir + 1, numberPiece.yDir] = numberPiece;
                matrix[numberPiece.xDir, numberPiece.yDir] = null;
                numberPiece.xDir += 1;
                break;
        }
        
        CheckWin();
    }
}
