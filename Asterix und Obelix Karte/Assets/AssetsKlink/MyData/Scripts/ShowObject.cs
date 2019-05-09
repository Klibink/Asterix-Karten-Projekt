using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
