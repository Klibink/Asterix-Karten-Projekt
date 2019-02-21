using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObject : MonoBehaviour {

    public ActivateLupe lupenObject;
    private Renderer renderer;

	// Use this for initialization
	void Start () {
        renderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        if (lupenObject.startMoving)
        {
            //gameObject.SetActive(true);
            renderer.enabled = true;
        }
        
    }

    private void OnMouseExit()
    {
        if (lupenObject.startMoving)
        {
            //gameObject.SetActive(false);
            renderer.enabled = false;
        }
    }
}
