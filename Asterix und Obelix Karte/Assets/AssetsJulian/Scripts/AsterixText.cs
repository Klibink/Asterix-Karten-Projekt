using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsterixText : MonoBehaviour
{

    public GameObject text;

    private void OnTriggerEnter()
    {
        text.SetActive(true);

    }

    private void OnTriggerExit()
    {
        text.SetActive(false);


    }

}
