using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour
{
    public string typ;
    
    public CameraControllerNeu camController;
    public Transform views;
    public ActivateLupe lupenScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (typ == "start")
            {
                camController.zustand = CameraControllerNeu.zustaende.zus1;
                lupenScript.startMoving= false;
            }
            if (typ == "asterix")
            {
                camController.zustand = CameraControllerNeu.zustaende.zus2;
                lupenScript.startMoving = false;
            }
            else if(typ == "lupe")
            {
                camController.zustand = CameraControllerNeu.zustaende.zus3;
                lupenScript.MoveGlass();
            }
            else if (typ == "globus")
            {
                camController.zustand = CameraControllerNeu.zustaende.zus4;
                lupenScript.startMoving = false;
            }



            
            camController.currentView = views;
        }
    }
}
