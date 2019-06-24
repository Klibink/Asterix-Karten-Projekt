using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aktiviert den MeshRenderer und vergrößert daraufhin die gewünschten GameObjekte
public class ShowObjectAndChangeSize : MonoBehaviour
{
    public GameObject go;
    private Renderer[] rend;
    private bool startGrowing = false;
    public Vector3 startScale;
    public Vector3 maxScale;

    public ActivateLupe lupenObject;
    private Renderer renderer;



    // Use this for initialization
    //Speichert alle Child Renderer in Array
    void Start()
    {
        rend = GetComponentsInChildren<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (startGrowing)
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
    //Erhöht den localScale des oder der gewünschten GameObjekte
    IEnumerator startGrow()
    {
        //transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        if (transform.lossyScale != maxScale)
        {
            transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
        }
        //SceneManager.LoadScene(nextScene);
    }

    //setzt alle Renderer in dem gespeicherten Render-Array auf "true"
    private void OnMouseOver()
    {
        if (lupenObject.startMoving)
        {
            foreach(Renderer r in rend)
            {
                r.enabled = true;
            }
            startGrowing = true;

            /*Transform[] children = new Transform[transform.childCount];            
            for (int i = 0; i < transform.childCount; i++)
            {
                children[i] = transform.GetChild(i);
                //children[i].GetComponent<Renderer>().enabled = true;
            }

            Transform[] allChildren = GetComponentsInChildren<Transform>();
            foreach(Transform child in children)
            {
                child.GetComponentInChildren<Renderer>().enabled = true;
                
            }
            */
            

           // Debug.Log(children);
        }


        
        Debug.Log("Test");
    }

    //setzt alle Renderer in dem gespeicherten Render-Array auf "false"
    private void OnMouseExit()
    {
        foreach (Renderer r in rend)
        {
            r.enabled = false;
        }
        startGrowing = false;

        /*if (lupenObject.startMoving)
        {
            Transform[] children = new Transform[transform.childCount];
            for (int i = 0; i < transform.childCount; i++)
            {
                children[i] = transform.GetChild(i);
                //children[i].GetComponent<Renderer>().enabled = true;
            }

            Transform[] allChildren = GetComponentsInChildren<Transform>();
            foreach (Transform child in children)
            {
                child.GetComponentInChildren<Renderer>().enabled = false;

            }


        }
        */

    }
}
