using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelAppear : MonoBehaviour
{
    public SpriteRenderer Panel;
    private CounterCollect CounterScript;
    public GameObject ScriptHolder;
    // Start is called before the first frame update
    void Start()
    {
        CounterScript = ScriptHolder.GetComponent<CounterCollect>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Player")
        {
            Debug.Log(other.tag);
            //  if (Panel != null)
            //   {
            Panel.enabled = true;
         //   }     
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            Debug.Log(other.tag);
            //  if (Panel != null)
            //   {
            Panel.enabled = false;
            CounterScript.counter();
            //   }     
        }
    }
}
