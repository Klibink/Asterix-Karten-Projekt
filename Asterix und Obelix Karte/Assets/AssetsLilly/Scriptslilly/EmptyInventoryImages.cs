using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyInventoryImages : MonoBehaviour
{
    private HUD HudScript;
    private Inventory Inventar;
    public GameObject ScriptHolder;
    public GameObject ScriptHolderINV;
    private float Timer;
    private bool trigger=false;
    private int Itemzahl;

    private void Start()
    {
        HudScript = ScriptHolder.GetComponent<HUD>();
        Inventar = ScriptHolderINV.GetComponent<Inventory>();
        Timer = 2f;
    }

    private void Update()
    {
        Timer -= 0.125f;
        delete();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Itemzahl = Inventar.returnItemCount()-1;
            trigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger = false;
            Itemzahl = 0;
        }
    }


    private void delete()
    {
        if (trigger)
        {
            if (Timer <= 0 && Itemzahl >= 0)
            {
                HudScript.Empty(Itemzahl);
                Timer = 2f;
                Itemzahl--;
            }
        }

    }
}
