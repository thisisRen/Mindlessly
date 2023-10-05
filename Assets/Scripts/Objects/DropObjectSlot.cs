using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// ReSharper disable All

public class DropObjectSlot : MonoBehaviour , IDropHandler
{

    [SerializeField] private int slotID;
    private DragObject _dragObject;
    private MinigameManager minigameManager;

    private void Awake()
    {
        minigameManager = transform.GetComponentInParent<MinigameManager>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        var dropObject = eventData.pointerDrag;
//        Debug.Log(dropObject.name);
        if (! dropObject.TryGetComponent(out DragObject dragObject)) return; 
        dragObject.transform.SetParent(transform);
        dragObject.holdingParent = this; 
        dragObject.transform.SetAsLastSibling();
        _dragObject = dragObject;
        minigameManager.CheckWin();
    }
    
    public bool CheckIfCorrect()
    {
        if (_dragObject is null)
        {
            GetComponent<Image>().color = Color.red;
            return false;
        }
        GetComponent<Image>().color = Color.green;
        return slotID == _dragObject.id;
    }
}
