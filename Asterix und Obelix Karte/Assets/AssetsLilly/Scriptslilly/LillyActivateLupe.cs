using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LillyActivateLupe : MonoBehaviour {

    public Vector3 startPos;
    public bool startMoving = false;
    public Player4 Player4Skript;
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
            Cursor.visible = false;
            Player4Skript.GameModeAsterix = false;
            //transform.position = Camera.main.ScreenToWorldPoint(new Vector3( Input.mousePosition.x,Input.mousePosition.y,-100));
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = actualDistance;
            transform.position = Camera.main.ScreenToWorldPoint(mousePosition);         
        }
        else
        {
            Cursor.visible = true;
            transform.position = startPos;
            Player4Skript.GameModeAsterix = true;
        }
         
        
        
	}


    public void MoveGlass()
    {
        startMoving = !startMoving; //trigger/untrigger Lupe
    }
}
