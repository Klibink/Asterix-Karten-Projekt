using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum zustaende { zus1, zus2, zus3, zus4 }

public class CameraControllerNeu : MonoBehaviour
{

    
    public zustaende zustand;

    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;

    void Start()
    {
        currentView = views[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentView = views[0];
            zustand = zustaende.zus1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentView = views[1];
            zustand = zustaende.zus2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentView = views[2];
            zustand = zustaende.zus3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentView = views[3];
            zustand = zustaende.zus4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentView = views[4];
        }
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3(
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;
    }
}