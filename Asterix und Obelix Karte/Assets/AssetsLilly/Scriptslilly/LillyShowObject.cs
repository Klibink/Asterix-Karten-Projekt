using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LillyShowObject : MonoBehaviour
{

    public ActivateLupe lupenObject;
    // private Renderer rends;
    private Renderer[] rends;
    // Use this for initialization
    void Start()
    {
        //renderer = GetComponent<Renderer>();
        Renderer[] rends = GetComponentsInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        if (lupenObject.startMoving)
        {
            //gameObject.SetActive(true);
            //renderer.enabled = true;
            foreach (var r in rends)
            {
                r.enabled = true;
            }
        }

    }

    private void OnMouseExit()
    {
        if (lupenObject.startMoving)
        {
            //gameObject.SetActive(false);
            //renderer.enabled = false;
            foreach (var r in rends)
            {
                r.enabled = true;
            }
        }
    }
}