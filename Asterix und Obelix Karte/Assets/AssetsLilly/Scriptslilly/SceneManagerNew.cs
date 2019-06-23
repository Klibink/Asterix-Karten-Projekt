using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace Mapbox.Examples
{    //Skript Manages Scenes in Game, so you can swap in between the different GameModes over the Menue
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
            public GameObject gallDorf;
            public TextMeshProUGUI text;

            private float myTime = 0f;
            public GameObject standardAnsicht;
            public GameObject asterixUI;
            public GameObject lupeUI;
            public GameObject globusUI;



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
                    gallDorf.SetActive(false);
                    text.text = "";
                    //Debug.Log(0);
                }
                if (cameraControllerScript.zustand == CameraControllerNeu.zustaende.zus2) //Asterix
                {
                    globus.GetComponent<DragRotate>().enabled = false;
                    asterixObject.SetActive(true);
                    Collectables.SetActive(true);
                    MovePoints.SetActive(true);
                    gallDorf.SetActive(false);

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
                    gallDorf.SetActive(true);
                    text.text = "";

                    //Debug.Log(2);
                }
                if (cameraControllerScript.zustand == CameraControllerNeu.zustaende.zus4) // Globus
                {
                    globus.GetComponent<SpawnOnGlobeExample>().enabled = true;
                    globus.GetComponent<DragRotate>().enabled = true;
                    text.text = "";
                    //Debug.Log(3);
                }

                myTime += Time.deltaTime;

                if(myTime > 6f)   //MenueTimer
                {
                    standardAnsicht.SetActive(true);
                    asterixUI.SetActive(true);
                    lupeUI.SetActive(true);
                    globusUI.SetActive(true);
                }

            }
        }
    }
}