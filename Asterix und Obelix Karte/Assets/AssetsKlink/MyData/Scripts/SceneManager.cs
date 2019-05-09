using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Mapbox.Examples
{
    namespace Scripts.Utilities
    {
        public class SceneManager : MonoBehaviour
        {
            public GameObject sceneCamera;
            public GameObject globus;
            public CameraControllerNeu cameraControllerScript;


            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {
                if (cameraControllerScript.zustand == zustaende.zus1)
                {
                    globus.GetComponent<DragRotate>().enabled = false;

                    //Debug.Log(0);
                }
                if (cameraControllerScript.zustand == zustaende.zus2)
                {
                    globus.GetComponent<DragRotate>().enabled = false;

                    //Debug.Log(1);
                }
                if (cameraControllerScript.zustand == zustaende.zus3)
                {
                    globus.GetComponent<SpawnOnGlobeExample>().enabled = true;
                    globus.GetComponent<DragRotate>().enabled = true;

                    //Debug.Log(2);
                }
                if (cameraControllerScript.zustand == zustaende.zus4)
                {
                    //Debug.Log(3);
                }
            }
        }
    }
}