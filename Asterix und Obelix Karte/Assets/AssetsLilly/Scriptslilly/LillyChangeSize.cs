using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LillyChangeSize : MonoBehaviour {

    //public Renderer rend;
    public GameObject toRender;
    private bool AllRendsEnabled;
    private Vector3 startScale = new Vector3(1, 1, 1);
    private Vector3 maxScale = new Vector3(2, 2, 2);



    // Use this for initialization
    void Start () {
        //rend = GetComponent<Renderer>();
        Renderer[] rends = toRender.GetComponentsInChildren<Renderer>();
        foreach (var r in rends)
        {
            if(r.enabled)
            {
                AllRendsEnabled = true;
            }
            else if (!r.enabled)
            {
                AllRendsEnabled = false;
            }
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (AllRendsEnabled)
        {
            //if(transform.lossyScale!=maxScale) { 
            StartCoroutine(startGrow());
            //}
        }
        else
        {

            transform.localScale = startScale;
        }

	}

    IEnumerator startGrow()
    {
        //transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.8f);
        if (transform.lossyScale != maxScale)
        {
            transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
        }
        //SceneManager.LoadScene(nextScene);
    }
}
