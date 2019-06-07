using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }
    public void OnPickup()
    {
        CounterScript.items.Add(-5);
        gameObject.SetActive(false);
        //CounterScript.itemnames.Add(Name);
        Debug.Log(Name);
    }
}
