using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sorgt dafür, dass das Lupen-Objekt dem Mouse-Cursor folgt
public class ActivateLupe : MonoBehaviour {

    public Vector3 startPos;
    public bool startMoving = false;

    public float distance = 1f;
    public bool useInitalCameraDistance = false;
    private float actualDistance;

	// Use this for initialization
	void Start () {
        startPos = transform.position;

        if (useInitalCameraDistance)
        {
            Vector3 toObjectVector = transform.position - Camera.main.transform.position;
            Vector3 linearDistanceVector = Vector3.Project(toObjectVector, Camera.main.transform.forward);
            actualDistance = linearDistanceVector.magnitude;
        }
        else
        {
            actualDistance = distance;
        }
    }
	
	// Update is called once per frame
	void Update () {

         if (startMoving)
         {
            
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = actualDistance;
            transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        }
        else
        {
            Cursor.visible = true;
            transform.position = startPos;
        }
         
        
        
	}


    public void MoveGlass()
    {
        startMoving = !startMoving; //Wechsel von true auf false und umgekehrt
    }
}
