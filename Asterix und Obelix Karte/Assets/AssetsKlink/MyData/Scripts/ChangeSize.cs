using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Verändert Größe eines GameObjects
public class ChangeSize : MonoBehaviour {

    private Renderer rend;
    private Vector3 startScale = new Vector3(0.2f, 0.2f, 0.2f);//Anfangsscale des Object
    private Vector3 maxScale = new Vector3(0.5f, 0.5f, 0.5f);//Endscale des Object



    // Use this for initialization
    void Start () {
        if (transform.childCount == 0)
        {
            rend = transform.GetComponent<Renderer>();
        }
        else
        {
            rend = transform.GetChild(0).GetComponent<Renderer>();

        }
        

	}
	
	// Update is called once per frame
	void Update () {

        if (rend.enabled)
        {
            
            StartCoroutine(startGrow());
            
        }
        else
        {

            transform.localScale = startScale;
        }

	}
    //Coroutine, die nach 0.8f Sekunden die oder das gewünschte Gameobject vergrößert
    IEnumerator startGrow()
    {
        
        yield return new WaitForSeconds(0.8f);
        if (transform.lossyScale != maxScale)
        {
            transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
        }
        
    }
}
