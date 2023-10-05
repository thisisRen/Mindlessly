using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

public class BlockBoxGame : MinigameManager
{
    
    [SerializeField] private List<DropObjectSlot> dropObjectSlots;
    
    [Button("Show")]
    public override void Show()
    {
        gameObject.SetActive(true);
    }

    public override void Hide()
    {
        gameObject.SetActive(false);
    }

    public override void OnGameStart()
    {
        throw new System.NotImplementedException();
    }

    public override void OnGameDone()
    {
        gameObject.SetActive(false);
    }

    public override void CheckWin()
    {
        var result = dropObjectSlots.All(x => x.CheckIfCorrect());
        if (!result) return;
        
        Debug.Log("Win");
        OnGameDone();

    }
}
