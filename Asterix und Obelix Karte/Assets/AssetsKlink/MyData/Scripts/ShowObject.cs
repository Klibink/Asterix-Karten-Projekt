﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// De- bzw. aktiviert den MeshRenderer einzelner GameObjekte, damit diese in Szene sichtbar werden, wenn das LupenObjekt über dem gewünschten Objekt hovert
public class ShowObject : MonoBehaviour {

    public ActivateLupe lupenObject;
    private Renderer renderer;
     
    private bool hasChild = false;

	// Use this for initialization
	void Start () {
        if (transform.childCount == 0) {
            renderer = GetComponent<Renderer>();
        }
        else
        {
            hasChild = true;
        }
        Debug.Log(transform.childCount);
        Debug.Log(hasChild);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //For-Loop, der die MeshRenderer aller ChildObjekte(sofern vorhanden) aktiviert
    private void OnMouseOver()
    {
        if (hasChild && lupenObject.startMoving)
        {
            Transform[] children = new Transform[transform.childCount];
            Renderer[] rendArray = new Renderer[transform.childCount];
            for (int i = 0; i < transform.childCount; i++)
            {
                children[i] = transform.GetChild(i);
                children[i].GetComponent<Renderer>().enabled = true;
            }

            Debug.Log(children);
        }


       else if (lupenObject.startMoving)
        {
            //gameObject.SetActive(true);
            renderer.enabled = true;
        }
        Debug.Log("Test");
    }

    //For-Loop, der die MeshRenderer aller ChildObjekte(sofern vorhanden) deaktiviert
    private void OnMouseExit()
    {
        if(hasChild && lupenObject.startMoving)
        {
            Transform[] children = new Transform[transform.childCount];
            Renderer[] rendArray = new Renderer[transform.childCount];
            for (int i = 0; i < transform.childCount; i++)
            {
                children[i] = transform.GetChild(i);
                children[i].GetComponent<Renderer>().enabled = false;
                //rendArray[i] = children[i].GetComponent<Renderer>();
            }

            
        }

        else if (lupenObject.startMoving)
        {
            //gameObject.SetActive(false);
            renderer.enabled = false;
        }
    }
}
