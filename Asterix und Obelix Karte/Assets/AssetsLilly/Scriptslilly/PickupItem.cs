using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skript that is part of all COllectible Items. 
// Adds an int to the CounterCollect list, so ItemImages can Change their Image over time (RottenEffect)

public class PickupItem : MonoBehaviour, IInventoryItem
{
    private CounterCollect CounterScript;
    public GameObject ScriptHolder;

    void Start()
    {
        CounterScript = ScriptHolder.GetComponent<CounterCollect>();
    }
    public string Name
    {
        get
        {
            // return "PickUpItem";
            return this.name;
        }
    }

    public Sprite _Image =null;
    public Sprite _ImageSchimmel =null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public Sprite ImageSchimmel
    {
        get
        {
            return _ImageSchimmel;
        }
    }

    public void OnPickup()
    {
        CounterScript.items.Add(-5);
        CounterScript.Schimmelpics.Add(_ImageSchimmel);
        gameObject.SetActive(false);
        //CounterScript.itemnames.Add(Name);
        Debug.Log(Name);
    }
}
