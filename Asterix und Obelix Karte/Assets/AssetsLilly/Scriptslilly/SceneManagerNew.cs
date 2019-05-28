using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Mapbox.Examples
{
    namespace Scripts.Utilities
    {
        public class SceneManagerNew : MonoBehaviour
        {
            public GameObject sceneCamera;
            public GameObject asterixObject;
            public GameObject Collectables;
            public GameObject MovePoints;
            public GameObject globus;
            public CameraControllerNeu cameraControllerScript;
            public GameObject vexilium;


            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {
                if (cameraControllerScript.zustand == CameraControllerNeu.zustaende.zus1) //startView
                {
                    globus.GetComponent<DragRotate>().enabled = false;
                    asterixObject.SetActive(false);
                    Collectables.SetActive(false);
                    MovePoints.SetActive(false);

                    //Debug.Log(0);
                }
                if (cameraControllerScript.zustand == CameraControllerNeu.zustaende.zus2) //Asterix
                {
                    globus.GetComponent<DragRotate>().enabled = false;
                    asterixObject.SetActive(true);
                    Collectables.SetActive(true);
                    MovePoints.SetActive(true);


                    //Debug.Log(1);
                }
                if (cameraControllerScript.zustand == CameraControllerNeu.zustaende.zus3) // Lupe
                {
                    //globus.GetComponent<SpawnOnGlobeExample>().enabled = true;
                    globus.GetComponent<DragRotate>().enabled = false;
                    asterixObject.SetActive(false);
                    Collectables.SetActive(false);
                    MovePoints.SetActive(false);
                    vexilium.SetActive(true);

                    //Debug.Log(2);
                }
                if (cameraControllerScript.zustand == CameraControllerNeu.zustaende.zus4) // Globus
                {
                    globus.GetComponent<SpawnOnGlobeExample>().enabled = true;
                    globus.GetComponent<DragRotate>().enabled = true;
                    //Debug.Log(3);
                }
            }
        }
    }
}