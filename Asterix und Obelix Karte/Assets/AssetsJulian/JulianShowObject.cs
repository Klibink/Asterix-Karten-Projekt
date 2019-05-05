using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JulianShowObject : MonoBehaviour

{

    public GameObject objectWithScript;
    public GameObject building;
    private LillyActivateLupe  script;
    public Vector3 maxScale = new Vector3(2, 2, 2);

 

    void Start()
    {
       script = objectWithScript.GetComponent<LillyActivateLupe>();
        

    }


    // Update is called once per frame
    void Update ()
    {
        
        
    }

    private void OnMouseOver()
    {
        if (script.startMoving)
        {
            StartCoroutine(startGrow());
        }

    }

   

        IEnumerator startGrow()
        {
            
            yield return new WaitForSeconds(0.1f);
            if (building.transform.lossyScale != maxScale)
            {
                building.transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
            }

    }



    }

    



