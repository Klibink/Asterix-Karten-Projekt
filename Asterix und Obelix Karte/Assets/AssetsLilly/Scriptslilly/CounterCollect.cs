using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Counts down for each Object that is put into Intems List, when timer Reaches 0 The Schimmel() function in the HUD is activated (-> Replaces Pic with RottenPic)

public class CounterCollect : MonoBehaviour
{
    private float counterMovePoints;

    public List<int> items = new List<int>();
    public List<Sprite> Schimmelpics = new List<Sprite>();

    private HUD HudScript;
    public GameObject ScriptHolder;

    // Start is called before the first frame update
    void Start()
    {
        HudScript = ScriptHolder.GetComponent<HUD>();
        counterMovePoints = 0;
    }

    void Update()
    {
        
    }
    public void counter()
    {
        counterMovePoints += 1;
        //Debug.Log(counterMovePoints);
        if (items.Count!=0)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] <= -1) //Items ist eine Int Liste! Hier ist der Zähler, der runterzählt bis Schimmel
                {
                    items[i] += 1;
                    //Debug.Log("item"+i+":"+items[i]);
                }
                else if (items[i] >= -1)
                {
                    HudScript.Schimmel(i, Schimmelpics[i]);
                    //Debug.Log("Item" + i + "Verfault");
                }

            }
        }
    }

   
}
