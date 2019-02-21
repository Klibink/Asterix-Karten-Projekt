using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour {

    public Renderer rend;
    private Vector3 startScale = new Vector3(1, 1, 1);
    private Vector3 maxScale = new Vector3(2, 2, 2);



    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        

	}
	
	// Update is called once per frame
	void Update () {

        if (rend.enabled)
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
