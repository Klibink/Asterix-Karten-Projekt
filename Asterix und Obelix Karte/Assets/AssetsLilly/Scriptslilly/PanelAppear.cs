﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// PanelsObjects are set to Active when Player collides with the DestinationPoints on Map. Each Point has an Image Attribut, that is already set to the correct PanelSprite
//when all objects have been collected from the DestinationPoints, the home-DestinationPoint is made visible (

public class PanelAppear : MonoBehaviour
{
    public SpriteRenderer Panel;
    private CounterCollect CounterScript;
    private Inventory InventarScript;
    public GameObject ScriptHolder;
    public GameObject ScriptHolderInv;
    public GameObject LastPoint;
    public string cityName;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
       
        CounterScript = ScriptHolder.GetComponent<CounterCollect>();
        InventarScript = ScriptHolderInv.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        text.text= cityName;
        if (other.tag == "Player")
        {
            //Debug.Log(other.tag);
            Panel.enabled = true;
            //Debug.Log(InventarScript.returnItemCout());
            if (InventarScript.returnItemCount()==9) //activate HomePoint
            {
                //Debug.Log("done");
                if (LastPoint.activeSelf ==false)
                {
                    LastPoint.SetActive(true);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            Debug.Log(other.tag);
            //  if (Panel != null)
            //   {
            text.text = "";
            Panel.enabled = false;
            CounterScript.counter();
            //   }     
        }
    }
}
