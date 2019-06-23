using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Inventory Items controller
public class Inventory : MonoBehaviour
{
    private const int SLOTS = 9;
    private List<IInventoryItem> mItems = new List<IInventoryItem>();
    public event EventHandler<InventoryEventArgs> ItemAdded;
    public event EventHandler<InventoryEventArgs> ItemSchimmel;

    public void AddItem(IInventoryItem item)
    {
        if(mItems.Count < SLOTS) {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider.enabled)
            {
                collider.enabled = false;
                mItems.Add(item);

                item.OnPickup();

                if (ItemAdded != null)
                {
                    ItemAdded(this, new InventoryEventArgs(item));
                }
            }
        }
        
    }

    public int returnItemCount()
    {
        return mItems.Count;
    }

    /*public void SchimmelItem(IInventoryItem item)
    {
        ItemSchimmel(this, new InventoryEventArgs(item));


    }*/
}
