using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PanelAppear : MonoBehaviour
{
    public SpriteRenderer Panel;
    private CounterCollect CounterScript;
    public GameObject ScriptHolder;
    public string cityName;
    public TextMeshProUGUI text;
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
        text.text= cityName;
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
            text.text = "";
            Panel.enabled = false;
            CounterScript.counter();
            //   }     
        }
    }
}
