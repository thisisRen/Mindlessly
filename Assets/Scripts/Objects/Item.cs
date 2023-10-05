using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[Serializable]
public class Item 
{

    public Sprite itemSprite;
    public string itemName; 
    public string itemDescription;
}

public enum ItemName
{
    Item1,
    Item2,
    Item3
}
