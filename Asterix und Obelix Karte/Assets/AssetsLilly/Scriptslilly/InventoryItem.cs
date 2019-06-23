using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
// Class for all Inventory Items  compare: https://www.youtube.com/watch?v=-xB4xEmGtCY&list=PLboXykqtm8dynMisqs4_oKvAIZedixvtf&index=1
public interface IInventoryItem
{
    string Name { get;  }
    Sprite Image { get; }
    Sprite ImageSchimmel { get; }
    void OnPickup();
}

public class InventoryEventArgs: EventArgs
{
    public InventoryEventArgs(IInventoryItem item)
    {
        Item = item;
    }
    public IInventoryItem Item;
}